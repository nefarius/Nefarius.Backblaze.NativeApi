using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

using Microsoft.Extensions.Options;

using Nefarius.Backblaze.NativeApi.WebApi;
using Nefarius.Backblaze.NativeApi.WebApi.Models;

using Refit;

namespace Nefarius.Backblaze.NativeApi;

/// <summary>
///     Provides functionality for uploading files or streams to Backblaze B2 cloud storage.
///     Implements the <see cref="IBackblazeUploader" /> interface.
/// </summary>
public class BackblazeUploader : IBackblazeUploader
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly BackblazeOptions _options;

    /// <summary>
    ///     Represents a class that facilitates the upload of files or streams to Backblaze B2 cloud storage.
    /// </summary>
    /// <remarks>
    ///     This class depends on <see cref="IHttpClientFactory" /> for HTTP communication and requires
    ///     Backblaze configuration settings through <see cref="BackblazeOptions" />.
    /// </remarks>
    public BackblazeUploader(
        IOptions<BackblazeOptions> options,
        IHttpClientFactory httpClientFactory)
    {
        _options = options.Value;
        _httpClientFactory = httpClientFactory;

        if (string.IsNullOrWhiteSpace(_options.KeyId))
        {
            throw new InvalidOperationException("Backblaze KeyId is not configured.");
        }

        if (string.IsNullOrWhiteSpace(_options.ApplicationKey))
        {
            throw new InvalidOperationException("Backblaze ApplicationKey is not configured.");
        }

        if (string.IsNullOrWhiteSpace(_options.BucketId))
        {
            throw new InvalidOperationException("Backblaze BucketId is not configured.");
        }
    }

    // ---------------------------------------------------------------------
    // PUBLIC OVERLOADS
    // ---------------------------------------------------------------------

    /// <summary>
    ///     Uploads a file to Backblaze B2 cloud storage using the specified file path.
    /// </summary>
    /// <param name="filePath">The full path of the file to upload.</param>
    /// <param name="cancellationToken">A cancellation token that can be used to cancel the operation.</param>
    /// <exception cref="ArgumentException">
    ///     Thrown when <paramref name="filePath" /> is null, empty, or consists only of
    ///     whitespace.
    /// </exception>
    /// <exception cref="FileNotFoundException">Thrown when the file specified by <paramref name="filePath" /> does not exist.</exception>
    /// <returns>A task that represents the asynchronous upload operation.</returns>
    public async Task UploadAsync(string filePath, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File to upload not found.", filePath);
        }

        await using FileStream stream = File.OpenRead(filePath);
        string fileName = Path.GetFileName(filePath);

        await UploadInternalAsync(stream, fileName, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    ///     Uploads a file to Backblaze B2 cloud storage.
    /// </summary>
    /// <param name="filePath">The full path of the file to upload.</param>
    /// <param name="targetFileName">The name of the file as it will appear in the target storage location.</param>
    /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for the task to complete.</param>
    /// <exception cref="ArgumentException">
    ///     Thrown if <paramref name="filePath" /> or <paramref name="targetFileName" /> is
    ///     null or whitespace.
    /// </exception>
    /// <exception cref="FileNotFoundException">Thrown if the specified file does not exist at <paramref name="filePath" />.</exception>
    /// <returns>A <see cref="Task" /> that represents the asynchronous operation.</returns>
    public async Task UploadAsync(string filePath, string targetFileName, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);
        ArgumentException.ThrowIfNullOrWhiteSpace(targetFileName);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException("File to upload not found.", filePath);
        }

        await using FileStream stream = File.OpenRead(filePath);
        await UploadInternalAsync(stream, targetFileName, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    ///     Uploads a stream of content to Backblaze B2 cloud storage with a specified target file name.
    /// </summary>
    /// <param name="content">The content stream to upload.</param>
    /// <param name="targetFileName">The name of the target file in the storage.</param>
    /// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
    /// <returns>A task that represents the asynchronous upload operation.</returns>
    /// <exception cref="ArgumentNullException">Thrown when <paramref name="content" /> is null.</exception>
    /// <exception cref="ArgumentException">Thrown when <paramref name="targetFileName" /> is null or whitespace.</exception>
    public async Task UploadAsync(Stream content, string targetFileName, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(content);
        ArgumentException.ThrowIfNullOrWhiteSpace(targetFileName);

        await UploadInternalAsync(content, targetFileName, cancellationToken).ConfigureAwait(false);
    }

    // ---------------------------------------------------------------------
    // INTERNAL UPLOAD LOGIC
    // ---------------------------------------------------------------------

    private async Task UploadInternalAsync(Stream stream, string targetFileName, CancellationToken cancellationToken)
    {
        if (stream.CanSeek)
        {
            stream.Seek(0, SeekOrigin.Begin);
        }

        // 1. Compute SHA1
        string sha1 = ComputeSha1(stream);

        if (stream.CanSeek)
        {
            stream.Seek(0, SeekOrigin.Begin);
        }

        // 2. Authorize
        B2AuthorizeAccountResponse authResponse = await AuthorizeAsync(cancellationToken).ConfigureAwait(false);

        // 3. Get upload URL
        B2GetUploadUrlResponse uploadUrlResponse = await GetUploadUrlAsync(authResponse, cancellationToken)
            .ConfigureAwait(false);

        // 4. Upload
        await UploadFileAsync(uploadUrlResponse, stream, targetFileName, sha1, cancellationToken)
            .ConfigureAwait(false);
    }

    private async Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken)
    {
        HttpClient client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Authorization);

        string authValue = Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{_options.KeyId}:{_options.ApplicationKey}"));

        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", authValue);

        IB2AuthorizationApi api = RestService.For<IB2AuthorizationApi>(client);

        return await api.AuthorizeAsync(cancellationToken).ConfigureAwait(false);
    }

    private async Task<B2GetUploadUrlResponse> GetUploadUrlAsync(
        B2AuthorizeAccountResponse auth,
        CancellationToken cancellationToken)
    {
        HttpClient client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Api);
        client.BaseAddress = new Uri(auth.ApiUrl);

        IB2BucketApi api = RestService.For<IB2BucketApi>(client);

        B2GetUploadUrlRequest request = new() { BucketId = _options.BucketId };

        return await api.GetUploadUrlAsync(request, auth.AuthorizationToken, cancellationToken)
            .ConfigureAwait(false);
    }

    private async Task UploadFileAsync(
        B2GetUploadUrlResponse uploadUrl,
        Stream stream,
        string rawFileName,
        string sha1,
        CancellationToken cancellationToken)
    {
        HttpClient client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Upload);
        client.BaseAddress = new Uri(uploadUrl.UploadUrl);

        IB2UploadApi api = RestService.For<IB2UploadApi>(client);

        // --- Backblaze filename & Content-Disposition handling ---
        string filenameOnly = Path.GetFileName(rawFileName);
        string encodedFileName = Uri.EscapeDataString(rawFileName);
        string utf8FileName = Uri.EscapeDataString(filenameOnly);
        string asciiFallback = new(filenameOnly.Select(c => c <= 127 ? c : '_').ToArray());

        string contentDisposition =
            Uri.EscapeDataString($"attachment; filename={asciiFallback}; filename*=UTF-8''{utf8FileName}");

        ApiResponse<string> response = await api.UploadAsync(
            uploadUrl.AuthorizationToken,
            encodedFileName,
            "b2/x-auto",
            sha1,
            contentDisposition,
            stream,
            cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
        {
            throw new InvalidOperationException(
                $"Backblaze B2 upload failed: {(int)response.StatusCode} {response.StatusCode}\n" +
                $"{response.Error?.Content}");
        }
    }

    private static string ComputeSha1(Stream stream)
    {
        using SHA1 sha1 = SHA1.Create();
        byte[] hash = sha1.ComputeHash(stream);
        return Convert.ToHexStringLower(hash);
    }
}
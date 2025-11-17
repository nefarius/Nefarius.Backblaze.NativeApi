using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Options;
using Refit;

namespace Nefarius.Backblaze.NativeApi;

public class BackblazeUploader : IBackblazeUploader
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly BackblazeOptions _options;

    public BackblazeUploader(
        IOptions<BackblazeOptions> options,
        IHttpClientFactory httpClientFactory)
    {
        _options = options.Value;
        _httpClientFactory = httpClientFactory;

        if (string.IsNullOrWhiteSpace(_options.KeyId))
            throw new InvalidOperationException("Backblaze KeyId is not configured.");

        if (string.IsNullOrWhiteSpace(_options.ApplicationKey))
            throw new InvalidOperationException("Backblaze ApplicationKey is not configured.");

        if (string.IsNullOrWhiteSpace(_options.BucketId))
            throw new InvalidOperationException("Backblaze BucketId is not configured.");
    }

    public async Task UploadAsync(string filePath, CancellationToken cancellationToken = default)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(filePath);

        if (!File.Exists(filePath))
            throw new FileNotFoundException("File to upload not found.", filePath);

        // 1. Authorize
        var authResponse = await AuthorizeAsync(cancellationToken).ConfigureAwait(false);

        // 2. Get upload URL for the bucket
        var uploadUrlResponse = await GetUploadUrlAsync(authResponse, cancellationToken)
            .ConfigureAwait(false);

        // 3. Compute SHA1 of file
        var sha1 = ComputeSha1(filePath);

        // 4. Upload file
        await UploadFileAsync(uploadUrlResponse, filePath, sha1, cancellationToken)
            .ConfigureAwait(false);
    }

    private async Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Authorization);

        var authValue = Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{_options.KeyId}:{_options.ApplicationKey}"));

        client.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Basic", authValue);

        var api = RestService.For<IB2AuthorizationApi>(client);

        return await api.AuthorizeAsync(cancellationToken).ConfigureAwait(false);
    }

    private async Task<B2GetUploadUrlResponse> GetUploadUrlAsync(
        B2AuthorizeAccountResponse auth,
        CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Api);
        client.BaseAddress = new Uri(auth.ApiUrl);

        var api = RestService.For<IB2BucketApi>(client);

        var request = new B2GetUploadUrlRequest
        {
            BucketId = _options.BucketId
        };

        return await api.GetUploadUrlAsync(request, auth.AuthorizationToken, cancellationToken)
            .ConfigureAwait(false);
    }

    private async Task UploadFileAsync(
        B2GetUploadUrlResponse uploadUrl,
        string filePath,
        string sha1,
        CancellationToken cancellationToken)
    {
        var client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Upload);
        client.BaseAddress = new Uri(uploadUrl.UploadUrl);

        var api = RestService.For<IB2UploadApi>(client);

        using var fs = File.OpenRead(filePath);

        var fileName = Path.GetFileName(filePath);
        var contentDisposition = $"attachment; filename=\"{fileName}\"";

        var response = await api.UploadAsync(
            uploadUrl.AuthorizationToken,
            fileName,
            "b2/x-auto",
            sha1,
            contentDisposition,
            fs,
            cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
            throw new InvalidOperationException(
                $"Backblaze B2 upload failed: {(int)response.StatusCode} {response.StatusCode}\n" +
                $"{response.Error?.Content}");
    }

    private static string ComputeSha1(string filePath)
    {
        using var stream = File.OpenRead(filePath);
        using var sha1 = SHA1.Create();
        var hash = sha1.ComputeHash(stream);
        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
    }
}
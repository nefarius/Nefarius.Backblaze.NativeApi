using System.Net.Http.Headers;
using System.Text;

using Microsoft.Extensions.Options;

using Nefarius.Backblaze.NativeApi.WebApi;
using Nefarius.Backblaze.NativeApi.WebApi.Models;

using Refit;

namespace Nefarius.Backblaze.NativeApi;

/// <summary>
///     Provides convenience access to bucket APIs such as listing file names.
/// </summary>
public sealed class BackblazeBucketClient : IBackblazeBucketClient
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly BackblazeOptions _options;

    /// <summary>
    ///     Initializes a new instance of the <see cref="BackblazeBucketClient" /> class.
    /// </summary>
    /// <param name="options">Configuration options for Backblaze B2.</param>
    /// <param name="httpClientFactory">Factory used to create HTTP clients.</param>
    public BackblazeBucketClient(IOptions<BackblazeOptions> options, IHttpClientFactory httpClientFactory)
    {
        _options = options.Value;
        _httpClientFactory = httpClientFactory;

        ValidateOptions();
    }

    /// <inheritdoc />
    public async Task<B2ListFileNamesResponse> ListFileNamesAsync(
        string? startFileName = null,
        int? maxFileCount = null,
        CancellationToken cancellationToken = default)
    {
        B2AuthorizeAccountResponse authResponse = await AuthorizeAsync(cancellationToken).ConfigureAwait(false);

        HttpClient client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Api);
        client.BaseAddress = new Uri(authResponse.ApiUrl);

        IB2BucketApi api = RestService.For<IB2BucketApi>(client);

        B2ListFileNamesRequest request = new()
        {
            BucketId = _options.BucketId,
            StartFileName = startFileName,
            MaxFileCount = maxFileCount
        };

        return await api.ListFileNamesAsync(request, authResponse.AuthorizationToken, cancellationToken)
            .ConfigureAwait(false);
    }

    /// <inheritdoc />
    public async Task<B2ListFileVersionsResponse> ListFileVersionsAsync(
        string? startFileName = null,
        string? startFileId = null,
        int? maxFileCount = null,
        CancellationToken cancellationToken = default)
    {
        B2AuthorizeAccountResponse authResponse = await AuthorizeAsync(cancellationToken).ConfigureAwait(false);

        HttpClient client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Api);
        client.BaseAddress = new Uri(authResponse.ApiUrl);

        IB2BucketApi api = RestService.For<IB2BucketApi>(client);

        B2ListFileVersionsRequest request = new()
        {
            BucketId = _options.BucketId,
            StartFileName = startFileName,
            StartFileId = startFileId,
            MaxFileCount = maxFileCount
        };

        return await api.ListFileVersionsAsync(request, authResponse.AuthorizationToken, cancellationToken)
            .ConfigureAwait(false);
    }

    private async Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken)
    {
        HttpClient client = _httpClientFactory.CreateClient(BackblazeHttpClientNames.Authorization);

        string authValue = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{_options.KeyId}:{_options.ApplicationKey}"));

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authValue);

        IB2AuthorizationApi api = RestService.For<IB2AuthorizationApi>(client);

        return await api.AuthorizeAsync(cancellationToken).ConfigureAwait(false);
    }

    private void ValidateOptions()
    {
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
}

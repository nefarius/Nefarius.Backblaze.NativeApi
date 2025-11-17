using Nefarius.Backblaze.NativeApi.WebApi.Models;

using Refit;

namespace Nefarius.Backblaze.NativeApi.WebApi;

/// <summary>
///     Defines methods for interacting with Backblaze B2 bucket-related API endpoints.
/// </summary>
public interface IB2BucketApi
{
    /// <summary>
    ///     Requests an upload URL for a specified bucket.
    /// </summary>
    /// <param name="request">The request containing the bucket ID for which to fetch the upload URL.</param>
    /// <param name="authToken">The authorization token to authenticate the API call.</param>
    /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
    /// <returns>A response containing an upload URL and authorization token for the specified bucket.</returns>
    [Post("/b2api/v2/b2_get_upload_url")]
    Task<B2GetUploadUrlResponse> GetUploadUrlAsync(
        [Body] B2GetUploadUrlRequest request,
        [Header("Authorization")] string authToken,
        CancellationToken cancellationToken = default);
}
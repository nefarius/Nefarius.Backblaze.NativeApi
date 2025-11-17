using Refit;

namespace Nefarius.Backblaze.NativeApi;

public interface IB2AuthorizationApi
{
    [Get("/b2api/v2/b2_authorize_account")]
    Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken = default);
}

public interface IB2BucketApi
{
    [Post("/b2api/v2/b2_get_upload_url")]
    Task<B2GetUploadUrlResponse> GetUploadUrlAsync(
        [Body] B2GetUploadUrlRequest request,
        [Header("Authorization")] string authToken,
        CancellationToken cancellationToken = default);
}

public interface IB2UploadApi
{
    [Post("")]
    Task<ApiResponse<string>> UploadAsync(
        [Header("Authorization")] string uploadAuthToken,
        [Header("X-Bz-File-Name")] string fileName,
        [Header("Content-Type")] string contentType,
        [Header("X-Bz-Content-Sha1")] string sha1,
        [Header("X-Bz-Info-Content-Disposition")]
        string contentDisposition,
        [Body] Stream content,
        CancellationToken cancellationToken = default);
}

public interface IBackblazeUploader
{
    /// <summary>
    ///     Uploads a local file to the configured Backblaze B2 bucket.
    /// </summary>
    /// <param name="filePath">Full path to the file to upload.</param>
    Task UploadAsync(string filePath, CancellationToken cancellationToken = default);
}
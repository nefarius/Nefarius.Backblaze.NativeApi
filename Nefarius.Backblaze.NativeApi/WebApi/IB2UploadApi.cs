using Refit;

namespace Nefarius.Backblaze.NativeApi.WebApi;

/// <summary>
///     Defines methods for uploading files to the Backblaze B2 Cloud Storage service.
/// </summary>
public interface IB2UploadApi
{
    /// <summary>
    ///     Uploads a file to the Backblaze B2 Cloud Storage service.
    /// </summary>
    /// <param name="uploadAuthToken">The authorization token obtained for the upload URL.</param>
    /// <param name="fileName">The name of the file being uploaded, URL-encoded.</param>
    /// <param name="contentType">The content type of the file, specified as a MIME type.</param>
    /// <param name="sha1">The SHA1 checksum of the file content for data integrity validation.</param>
    /// <param name="contentDisposition">Specifies how the content should be displayed, including filename handling.</param>
    /// <param name="content">The file content stream to be uploaded.</param>
    /// <param name="cancellationToken">A cancellation token for managing the upload operation.</param>
    /// <returns>A task representing the asynchronous operation, containing the server response as a string on success.</returns>
    [Post("")]
    Task<ApiResponse<string>> UploadAsync(
        [Header("Authorization")] string uploadAuthToken,
        [Header("X-Bz-File-Name")] string fileName,
        [Header("Content-Type")] string contentType,
        [Header("X-Bz-Content-Sha1")] string sha1,
        [Header("X-Bz-Info-b2-content-disposition")]
        string contentDisposition,
        [Body] Stream content,
        CancellationToken cancellationToken = default);
}
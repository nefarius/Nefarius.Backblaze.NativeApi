using Refit;

namespace Nefarius.Backblaze.NativeApi.WebApi;

public interface IB2UploadApi
{
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
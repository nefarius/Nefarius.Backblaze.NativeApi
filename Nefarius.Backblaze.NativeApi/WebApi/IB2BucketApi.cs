using Nefarius.Backblaze.NativeApi.WebApi.Models;

using Refit;

namespace Nefarius.Backblaze.NativeApi.WebApi;

public interface IB2BucketApi
{
    [Post("/b2api/v2/b2_get_upload_url")]
    Task<B2GetUploadUrlResponse> GetUploadUrlAsync(
        [Body] B2GetUploadUrlRequest request,
        [Header("Authorization")] string authToken,
        CancellationToken cancellationToken = default);
}
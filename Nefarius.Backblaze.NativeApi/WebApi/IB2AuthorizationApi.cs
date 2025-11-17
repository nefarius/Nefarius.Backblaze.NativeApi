using Nefarius.Backblaze.NativeApi.WebApi.Models;

using Refit;

namespace Nefarius.Backblaze.NativeApi.WebApi;

public interface IB2AuthorizationApi
{
    [Get("/b2api/v2/b2_authorize_account")]
    Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken = default);
}
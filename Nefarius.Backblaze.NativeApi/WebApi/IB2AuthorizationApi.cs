using Nefarius.Backblaze.NativeApi.WebApi.Models;

using Refit;

namespace Nefarius.Backblaze.NativeApi.WebApi;

/// <summary>
///     Represents the authorization API for Backblaze B2.
///     Provides methods to authorize an account with the Backblaze B2 service,
///     enabling further interaction with the API.
/// </summary>
public interface IB2AuthorizationApi
{
    /// <summary>
    ///     Authorizes an account with the Backblaze B2 service, establishing the necessary
    ///     credentials for further API interactions.
    /// </summary>
    /// <param name="cancellationToken">A cancellation token to cancel the asynchronous operation.</param>
    /// <returns>
    ///     A task that represents the asynchronous operation. The task result contains the
    ///     authorization response with details like account ID, authorization token, and service URLs.
    /// </returns>
    [Get("/b2api/v2/b2_authorize_account")]
    Task<B2AuthorizeAccountResponse> AuthorizeAsync(CancellationToken cancellationToken = default);
}
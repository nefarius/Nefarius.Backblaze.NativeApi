using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents the response returned after successfully authorizing an account with the Backblaze B2 API.
///     This response contains essential details required for accessing other API functionalities,
///     such as the account ID, authorization token, and API endpoints.
/// </summary>
public sealed class B2AuthorizeAccountResponse
{
    /// <summary>
    ///     Gets or sets the unique identifier of the authorized Backblaze B2 account.
    ///     This identifier is used to associate requests with a specific account
    ///     after successful authorization.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///     Gets or sets the authorization token required for accessing authorized API endpoints
    ///     in the Backblaze B2 system. This token is issued upon successful account authorization
    ///     and must be included in the headers of subsequent API requests to validate access rights.
    /// </summary>
    [JsonPropertyName("authorizationToken")]
    public string AuthorizationToken { get; set; }

    /// <summary>
    ///     Gets or sets the base URL of the Backblaze B2 API for the authorized account.
    ///     This URL serves as the endpoint for making API requests specific to the account
    ///     after successful authorization.
    /// </summary>
    [JsonPropertyName("apiUrl")]
    public string ApiUrl { get; set; }

    /// <summary>
    ///     Gets or sets the URL for downloading files from the Backblaze B2 cloud storage.
    ///     This URL serves as the endpoint for direct file access and retrieval operations.
    /// </summary>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }
}
using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents the response from the Backblaze B2 API when requesting an upload URL for a specific bucket.
/// </summary>
/// <remarks>
///     The response includes the bucket ID, an upload URL, and an authorization token.
///     These values are required to directly upload files to the designated bucket.
/// </remarks>
public sealed class B2GetUploadUrlResponse
{
    /// <summary>
    ///     Gets or sets the unique identifier of the bucket associated with the upload URL.
    /// </summary>
    /// <remarks>
    ///     This property identifies the specific bucket to which files will be uploaded.
    ///     It is part of the response returned by the Backblaze B2 API when an upload URL is requested.
    /// </remarks>
    [JsonPropertyName("bucketId")]
    public string BucketId { get; set; }

    /// <summary>
    ///     Gets or sets the URL to which files will be directly uploaded in the designated bucket.
    /// </summary>
    /// <remarks>
    ///     The value of this property is provided in the response from the Backblaze B2 API when requesting an upload URL.
    ///     The URL is specific to a given bucket and is used in conjunction with an authorization token for performing
    ///     uploads.
    /// </remarks>
    [JsonPropertyName("uploadUrl")]
    public string UploadUrl { get; set; }

    /// <summary>
    ///     Gets or sets the authorization token required to authenticate file uploads to the designated bucket.
    /// </summary>
    /// <remarks>
    ///     This property represents the token returned by the Backblaze B2 API when requesting an upload URL.
    ///     The token is used to authorize file uploads and must be included in the "Authorization" header of uploading
    ///     requests.
    /// </remarks>
    [JsonPropertyName("authorizationToken")]
    public string AuthorizationToken { get; set; }
}
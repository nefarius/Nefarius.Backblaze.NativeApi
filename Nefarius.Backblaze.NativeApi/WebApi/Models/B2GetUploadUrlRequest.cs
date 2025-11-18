using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents a request to retrieve an upload URL for a specified bucket in the Backblaze B2 Cloud Storage service.
/// </summary>
public sealed class B2GetUploadUrlRequest
{
    /// <summary>
    ///     Gets or sets the unique identifier of the bucket for which the upload URL is being requested.
    ///     This property is used to specify the target bucket in operations involving the Backblaze B2 Cloud Storage service.
    /// </summary>
    [JsonPropertyName("bucketId")]
    public string BucketId { get; set; }
}
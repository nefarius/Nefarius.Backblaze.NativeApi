using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents a request to list different versions of files within a Backblaze B2 bucket.
/// </summary>
public sealed class B2ListFileVersionsRequest
{
    /// <summary>
    ///     Gets or sets the unique identifier of the bucket to list file versions from.
    /// </summary>
    [JsonPropertyName("bucketId")]
    public string BucketId { get; set; }

    /// <summary>
    ///     Gets or sets the file name to start listing from. If null, listing starts from the first
    ///     file in the bucket.
    /// </summary>
    [JsonPropertyName("startFileName")]
    public string? StartFileName { get; set; }

    /// <summary>
    ///     Gets or sets the file identifier to start listing from, used together with <see cref="StartFileName" />
    ///     for pagination.
    /// </summary>
    [JsonPropertyName("startFileId")]
    public string? StartFileId { get; set; }

    /// <summary>
    ///     Gets or sets the maximum number of file versions to return.
    /// </summary>
    [JsonPropertyName("maxFileCount")]
    public int? MaxFileCount { get; set; }
}

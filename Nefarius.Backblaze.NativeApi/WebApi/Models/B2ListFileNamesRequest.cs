using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents a request to retrieve file names from a specific Backblaze B2 bucket.
/// </summary>
public sealed class B2ListFileNamesRequest
{
    /// <summary>
    ///     Gets or sets the unique identifier of the bucket to list files from.
    /// </summary>
    [JsonPropertyName("bucketId")]
    public string BucketId { get; set; }

    /// <summary>
    ///     Gets or sets the name of the first file to return. If null, the listing starts
    ///     from the first file in the bucket.
    /// </summary>
    [JsonPropertyName("startFileName")]
    public string? StartFileName { get; set; }

    /// <summary>
    ///     Gets or sets the maximum number of file names to return. Defaults to the
    ///     service value when not specified.
    /// </summary>
    [JsonPropertyName("maxFileCount")]
    public int? MaxFileCount { get; set; }
}

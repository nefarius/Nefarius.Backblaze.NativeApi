using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents the response returned when listing file versions in a Backblaze B2 bucket.
/// </summary>
public sealed class B2ListFileVersionsResponse
{
    /// <summary>
    ///     Gets or sets the collection of file versions returned by the listing operation.
    /// </summary>
    [JsonPropertyName("files")]
    public IEnumerable<B2StorageFile> Files { get; set; }

    /// <summary>
    ///     Gets or sets the name of the next file to start the listing from, or null when
    ///     there are no additional versions.
    /// </summary>
    [JsonPropertyName("nextFileName")]
    public string? NextFileName { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the next file to start the listing from, or null when
    ///     there are no additional versions.
    /// </summary>
    [JsonPropertyName("nextFileId")]
    public string? NextFileId { get; set; }
}

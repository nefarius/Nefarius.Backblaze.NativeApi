using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents the response returned when listing file names in a Backblaze B2 bucket.
/// </summary>
public sealed class B2ListFileNamesResponse
{
    /// <summary>
    ///     Gets or sets the collection of files returned by the listing operation.
    /// </summary>
    [JsonPropertyName("files")]
    public IEnumerable<B2StorageFile> Files { get; set; }

    /// <summary>
    ///     Gets or sets the name of the next file to start the listing from, or null when
    ///     there are no additional files.
    /// </summary>
    [JsonPropertyName("nextFileName")]
    public string? NextFileName { get; set; }
}

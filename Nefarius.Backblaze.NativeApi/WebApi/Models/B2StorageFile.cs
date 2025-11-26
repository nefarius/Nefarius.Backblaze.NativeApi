using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

/// <summary>
///     Represents metadata about a stored file returned by Backblaze B2 listing operations.
/// </summary>
public sealed class B2StorageFile
{
    /// <summary>
    ///     Gets or sets the unique identifier of the account that owns the file.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }

    /// <summary>
    ///     Gets or sets the identifier of the bucket containing the file.
    /// </summary>
    [JsonPropertyName("bucketId")]
    public string BucketId { get; set; }

    /// <summary>
    ///     Gets or sets the action that created this file version, such as "upload" or "delete".
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }

    /// <summary>
    ///     Gets or sets the unique identifier assigned to the file.
    /// </summary>
    [JsonPropertyName("fileId")]
    public string FileId { get; set; }

    /// <summary>
    ///     Gets or sets the name of the file within the bucket.
    /// </summary>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }

    /// <summary>
    ///     Gets or sets the size of the file in bytes.
    /// </summary>
    [JsonPropertyName("contentLength")]
    public long ContentLength { get; set; }

    /// <summary>
    ///     Gets or sets the MIME type of the file.
    /// </summary>
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; }

    /// <summary>
    ///     Gets or sets the SHA1 hash of the file contents.
    /// </summary>
    [JsonPropertyName("contentSha1")]
    public string ContentSha1 { get; set; }

    /// <summary>
    ///     Gets or sets optional MD5 hash of the file contents.
    /// </summary>
    [JsonPropertyName("contentMd5")]
    public string? ContentMd5 { get; set; }

    /// <summary>
    ///     Gets or sets additional metadata associated with the file.
    /// </summary>
    [JsonPropertyName("fileInfo")]
    public Dictionary<string, string> FileInfo { get; set; }

    /// <summary>
    ///     Gets or sets the upload timestamp in milliseconds since the epoch.
    /// </summary>
    [JsonPropertyName("uploadTimestamp")]
    public long UploadTimestamp { get; set; }
}

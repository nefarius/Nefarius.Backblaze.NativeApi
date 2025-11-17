using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi;

/// <summary>
///     Represents configuration options for interacting with Backblaze B2 cloud storage.
/// </summary>
/// <remarks>
///     The <see cref="BackblazeOptions" /> class stores credentials and settings used to authenticate
///     and interact with Backblaze B2 cloud storage. These settings include the key ID, application key,
///     and the bucket ID for a specific B2 bucket. This class is typically configured through
///     dependency injection and used by services requiring Backblaze authentication and interaction.
/// </remarks>
public class BackblazeOptions
{
    public const string SectionName = "Backblaze";

    /// <summary>
    ///     Gets or sets the Key ID used for authenticating with Backblaze B2 cloud storage.
    /// </summary>
    /// <remarks>
    ///     The Key ID is a credential required to authorize requests to the Backblaze B2 API.
    ///     It works in combination with the Application Key to perform secure operations,
    ///     such as uploading files, downloading files, and managing buckets.
    ///     This property should be supplied with a valid value obtained from the Backblaze B2 account dashboard.
    /// </remarks>
    [JsonPropertyName("KeyId")]
    public string KeyId { get; set; }

    /// <summary>
    ///     Gets or sets the Application Key used for authenticating with Backblaze B2 cloud storage.
    /// </summary>
    /// <remarks>
    ///     The Application Key, in conjunction with the Key ID, serves as a credential for secure communication
    ///     with the Backblaze B2 API. It allows the client to perform tasks such as uploading files,
    ///     downloading files, and managing buckets. Ensure this property is assigned a valid application key
    ///     obtained from the Backblaze B2 account dashboard or configuration settings.
    /// </remarks>
    [JsonPropertyName("ApplicationKey")]
    public string ApplicationKey { get; set; }

    /// <summary>
    ///     Gets or sets the Bucket ID associated with a specific bucket in Backblaze B2 cloud storage.
    /// </summary>
    /// <remarks>
    ///     The Bucket ID uniquely identifies a storage bucket within the Backblaze B2 account. It is required
    ///     to perform various bucket-level operations, such as uploading files, retrieving bucket information,
    ///     and obtaining upload URLs. This property must be configured with a valid Bucket ID retrieved from the
    ///     Backblaze B2 account management interface.
    /// </remarks>
    [JsonPropertyName("BucketId")]
    public string BucketId { get; set; }
}
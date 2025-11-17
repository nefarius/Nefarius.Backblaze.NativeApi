using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi;

public class BackblazeOptions
{
    public const string SectionName = "Backblaze";

    [JsonPropertyName("KeyId")]
    public string KeyId { get; set; }

    [JsonPropertyName("ApplicationKey")]
    public string ApplicationKey { get; set; }

    [JsonPropertyName("BucketId")]
    public string BucketId { get; set; }
}
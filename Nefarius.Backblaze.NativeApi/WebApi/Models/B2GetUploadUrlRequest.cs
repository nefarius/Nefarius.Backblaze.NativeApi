using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

public class B2GetUploadUrlRequest
{
    [JsonPropertyName("bucketId")] public string BucketId { get; set; }
}
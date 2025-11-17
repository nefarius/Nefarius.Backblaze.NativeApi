using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

public class B2GetUploadUrlResponse
{
    [JsonPropertyName("bucketId")] public string BucketId { get; set; }

    [JsonPropertyName("uploadUrl")] public string UploadUrl { get; set; }

    [JsonPropertyName("authorizationToken")]
    public string AuthorizationToken { get; set; }
}
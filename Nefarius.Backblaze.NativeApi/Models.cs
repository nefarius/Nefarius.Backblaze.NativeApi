using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi;

internal static class BackblazeHttpClientNames
{
    public const string Authorization = "Backblaze.B2.Auth";
    public const string Api = "Backblaze.B2.Api";
    public const string Upload = "Backblaze.B2.Upload";
}

public class BackblazeOptions
{
    public const string SectionName = "Backblaze";

    [JsonPropertyName("KeyId")] public string KeyId { get; set; }

    [JsonPropertyName("ApplicationKey")] public string ApplicationKey { get; set; }

    [JsonPropertyName("BucketId")] public string BucketId { get; set; }
}

public class B2AuthorizeAccountResponse
{
    [JsonPropertyName("accountId")] public string AccountId { get; set; }

    [JsonPropertyName("authorizationToken")]
    public string AuthorizationToken { get; set; }

    [JsonPropertyName("apiUrl")] public string ApiUrl { get; set; }

    [JsonPropertyName("downloadUrl")] public string DownloadUrl { get; set; }
}

public class B2GetUploadUrlRequest
{
    [JsonPropertyName("bucketId")] public string BucketId { get; set; }
}

public class B2GetUploadUrlResponse
{
    [JsonPropertyName("bucketId")] public string BucketId { get; set; }

    [JsonPropertyName("uploadUrl")] public string UploadUrl { get; set; }

    [JsonPropertyName("authorizationToken")]
    public string AuthorizationToken { get; set; }
}
using System.Text.Json.Serialization;

namespace Nefarius.Backblaze.NativeApi.WebApi.Models;

public class B2AuthorizeAccountResponse
{
    [JsonPropertyName("accountId")]
    public string AccountId { get; set; }

    [JsonPropertyName("authorizationToken")]
    public string AuthorizationToken { get; set; }

    [JsonPropertyName("apiUrl")]
    public string ApiUrl { get; set; }

    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }
}
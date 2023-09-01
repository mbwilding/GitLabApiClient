using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class ExportStatusLinks
{
    [JsonPropertyName("api_url")]
    public string ApiUrl { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }
}
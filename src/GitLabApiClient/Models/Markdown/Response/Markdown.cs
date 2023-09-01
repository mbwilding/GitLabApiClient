using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Markdown.Response;

public sealed class Markdown
{
    [JsonPropertyName("html")]
    public string Html { get; set; }
}
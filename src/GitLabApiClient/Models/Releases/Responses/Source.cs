using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Releases.Responses;

public sealed class Source
{
    [JsonPropertyName("format")]
    public string Format { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}
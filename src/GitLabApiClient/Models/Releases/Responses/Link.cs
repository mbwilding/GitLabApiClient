using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Releases.Responses;

public sealed class Link
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("external")]
    public bool External { get; set; }
}
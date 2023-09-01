using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Trees.Responses;

public sealed class Tree
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("mode")]
    public string Mode { get; set; }
}
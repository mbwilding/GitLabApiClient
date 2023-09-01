using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class Namespace
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("full_path")]
    public string FullPath { get; set; }

    [JsonPropertyName("kind")]
    public string Kind { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }
}
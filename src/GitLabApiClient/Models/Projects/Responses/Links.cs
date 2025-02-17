using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class Links
{
    [JsonPropertyName("members")]
    public string Members { get; set; }

    [JsonPropertyName("issues")]
    public string Issues { get; set; }

    [JsonPropertyName("events")]
    public string Events { get; set; }

    [JsonPropertyName("labels")]
    public string Labels { get; set; }

    [JsonPropertyName("repo_branches")]
    public string RepoBranches { get; set; }

    [JsonPropertyName("merge_requests")]
    public string MergeRequests { get; set; }

    [JsonPropertyName("self")]
    public string Self { get; set; }
}
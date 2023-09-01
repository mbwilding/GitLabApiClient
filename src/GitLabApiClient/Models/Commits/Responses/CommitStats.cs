using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Commits.Responses;

public class CommitStats
{
    [JsonPropertyName("additions")]
    public int Additions { get; set; }
    [JsonPropertyName("deletions")]
    public int Deletions { get; set; }
    [JsonPropertyName("total")]
    public int Total { get; set; }
}
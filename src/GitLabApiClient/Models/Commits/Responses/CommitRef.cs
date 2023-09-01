using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Commits.Responses;

public class CommitRef
{
    [JsonPropertyName("type")]
    public CommitRefType Type { get; set; } = CommitRefType.All;

    [JsonPropertyName("name")]
    public string Name { get; set; }
}
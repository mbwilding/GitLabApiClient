using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Issues.Responses;

public class IssueTaskCompletionStatus
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("completed_count")]
    public int Completed { get; set; }
}
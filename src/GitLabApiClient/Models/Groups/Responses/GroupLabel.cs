using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Groups.Responses;

public sealed class GroupLabel
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("color")]
    public string Color { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("open_issues_count")]
    public int OpenIssuesCount { get; set; }

    [JsonPropertyName("closed_issues_count")]
    public int ClosedIssuesCount { get; set; }

    [JsonPropertyName("open_merge_requests_count")]
    public int OpenMergeRequestsCount { get; set; }

    [JsonPropertyName("subscribed")]
    public bool Subscribed { get; set; }
}
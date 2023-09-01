using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Issues.Requests;

public enum UpdatedIssueState
{
    [JsonPropertyName("close")]
    Close,

    [JsonPropertyName("reopen")]
    Reopen
}
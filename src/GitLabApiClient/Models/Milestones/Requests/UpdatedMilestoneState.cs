using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Milestones.Requests;

public enum UpdatedMilestoneState
{
    [JsonPropertyName("close")]
    Close,

    [JsonPropertyName("activate")]
    Activate
}
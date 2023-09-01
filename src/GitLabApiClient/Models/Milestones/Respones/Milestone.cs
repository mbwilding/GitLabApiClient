using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Milestones.Responses;

public sealed class Milestone : ModifiableObject
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("due_date")]
    public string DueDate { get; set; }

    [JsonPropertyName("start_date")]
    public string StartDate { get; set; }

    [JsonPropertyName("project_id")]
    public int? ProjectId { get; set; }

    [JsonPropertyName("group_id")]
    public int? GroupId { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("state")]
    public MilestoneState State { get; set; }
}
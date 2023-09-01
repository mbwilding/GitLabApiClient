using System;
using System.Collections.Generic;
using GitLabApiClient.Models.Milestones.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Issues.Responses;

public sealed class Issue : ModifiableObject
{
    [JsonPropertyName("confidential")]
    public bool Confidential { get; set; }

    [JsonPropertyName("assignees")]
    public List<Assignee> Assignees { get; } = new();

    [JsonPropertyName("assignee")]
    public Assignee Assignee { get; set; }

    [JsonPropertyName("author")]
    public Assignee Author { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("due_date")]
    public string DueDate { get; set; }

    [JsonPropertyName("project_id")]
    public string ProjectId { get; set; }

    [JsonPropertyName("labels")]
    public List<string> Labels { get; } = new();

    [JsonPropertyName("milestone")]
    public Milestone Milestone { get; set; }

    [JsonPropertyName("closed_at")]
    public DateTime? ClosedAt { get; set; }

    [JsonPropertyName("closed_by")]
    public ClosedBy ClosedBy { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("user_notes_count")]
    public int UserNotesCount { get; set; }

    [JsonPropertyName("state")]
    public IssueState State { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }

    [JsonPropertyName("time_stats")]
    public IssueTimeStatistic TimeStats { get; set; }

    [JsonPropertyName("task_completion_status")]
    public IssueTaskCompletionStatus TaskCompletionStatus { get; set; }
}
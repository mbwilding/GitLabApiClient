using System;
using System.Collections.Generic;
using GitLabApiClient.Models.Issues.Responses;
using GitLabApiClient.Models.Milestones.Responses;
using GitLabApiClient.Models.Pipelines.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.MergeRequests.Responses;

public sealed class MergeRequest : ModifiableObject
{
    [JsonPropertyName("labels")]
    public List<string> Labels { get; } = new();

    [JsonPropertyName("source_branch")]
    public string SourceBranch { get; set; }

    [JsonPropertyName("downvotes")]
    public int Downvotes { get; set; }

    [JsonPropertyName("author")]
    public Assignee Author { get; set; }

    [JsonPropertyName("assignee")]
    public Assignee Assignee { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("force_remove_source_branch")]
    public bool ForceRemoveSourceBranch { get; set; }

    [JsonPropertyName("milestone")]
    public Milestone Milestone { get; set; }

    [JsonPropertyName("merge_status")]
    public MergeStatus Status { get; set; }

    [JsonPropertyName("merge_commit_sha")]
    public string MergeCommitSha { get; set; }

    [JsonPropertyName("merge_when_pipeline_succeeds")]
    public bool MergeWhenPipelineSucceeds { get; set; }

    [JsonPropertyName("sha")]
    public string Sha { get; set; }

    [JsonPropertyName("project_id")]
    public string ProjectId { get; set; }

    [JsonPropertyName("should_remove_source_branch")]
    public bool? ShouldRemoveSourceBranch { get; set; }

    [JsonPropertyName("target_project_id")]
    public int TargetProjectId { get; set; }

    [JsonPropertyName("state")]
    public MergeRequestState State { get; set; }

    [JsonPropertyName("source_project_id")]
    public int SourceProjectId { get; set; }

    [JsonPropertyName("closed_at")]
    public DateTime? ClosedAt { get; set; }

    [JsonPropertyName("closed_by")]
    public ClosedBy ClosedBy { get; set; }

    [JsonPropertyName("target_branch")]
    public string TargetBranch { get; set; }

    [JsonPropertyName("upvotes")]
    public int Upvotes { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("user_notes_count")]
    public int UserNotesCount { get; set; }

    [JsonPropertyName("work_in_progress")]
    public bool WorkInProgress { get; set; }

    [JsonPropertyName("time_stats")]
    public MergeRequestTimeStatistic TimeStats { get; set; }

    [JsonPropertyName("pipeline")]
    public Pipeline Pipeline { get; set; }

    [JsonPropertyName("merged_by")]
    public Assignee MergedBy { get; set; }
}
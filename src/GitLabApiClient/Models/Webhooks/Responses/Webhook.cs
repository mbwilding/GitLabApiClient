using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Webhooks.Responses;

public sealed class Webhook
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("push_events")]
    public bool PushEvents { get; set; }

    [JsonPropertyName("push_events_branch_filter")]
    public string PushEventsBranchFilter { get; set; }

    [JsonPropertyName("issues_events")]
    public bool IssuesEvents { get; set; }

    [JsonPropertyName("confidential_issues_events")]
    public bool ConfidentialIssuesEvents { get; set; }

    [JsonPropertyName("merge_requests_events")]
    public bool MergeRequestsEvents { get; set; }

    [JsonPropertyName("tag_push_events")]
    public bool TagPushEvents { get; set; }

    [JsonPropertyName("note_events")]
    public bool NoteEvents { get; set; }

    [JsonPropertyName("job_events")]
    public bool JobEvents { get; set; }

    [JsonPropertyName("pipeline_events")]
    public bool PipelineEvents { get; set; }

    [JsonPropertyName("wiki_page_events")]
    public bool WikiPageEvents { get; set; }

    [JsonPropertyName("enable_ssl_verification")]
    public bool EnableSslVerification { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

}
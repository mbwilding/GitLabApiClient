using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Commits.Responses;

public sealed class Commit
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("short_id")]
    public string ShortId { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("author_name")]
    public string AuthorName { get; set; }
    [JsonPropertyName("author_email")]
    public string AuthorEmail { get; set; }
    [JsonPropertyName("authored_date")]
    public DateTime AuthoredDate { get; set; }
    [JsonPropertyName("committer_name")]
    public string CommitterName { get; set; }
    [JsonPropertyName("committer_email")]
    public string CommitterEmail { get; set; }
    [JsonPropertyName("committed_date")]
    public DateTime CommittedDate { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
    [JsonPropertyName("parent_ids")]
    public List<string> ParentIds { get; } = new();
    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }
    [JsonPropertyName("stats")]
    public CommitStats CommitStats { get; set; }

}
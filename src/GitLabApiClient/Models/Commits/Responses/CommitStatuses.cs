using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Commits.Responses;

public sealed class CommitStatuses
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
    [JsonPropertyName("sha")]
    public string Sha { get; set; }
    [JsonPropertyName("ref")]
    public string Ref { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("target_url")]
    public string TargetUrl { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonPropertyName("started_at")]
    public DateTime StartedAt { get; set; }
    [JsonPropertyName("finished_at")]
    public DateTime FinishedAt { get; set; }
    [JsonPropertyName("allow_failure")]
    public bool AllowFailure { get; set; }
    [JsonPropertyName("coverage")]
    public float? Coverage { get; set; }
    [JsonPropertyName("author")]
    public Author Author { get; set; }

}
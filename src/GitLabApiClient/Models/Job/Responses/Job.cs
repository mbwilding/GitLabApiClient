using System;
using GitLabApiClient.Models.Commits.Responses;
using GitLabApiClient.Models.Pipelines.Responses;
using GitLabApiClient.Models.Runners.Responses;
using GitLabApiClient.Models.Users.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Job.Responses;

public sealed class Job
{
    [JsonPropertyName("allow_failure")]
    public bool AllowFailure { get; set; }

    [JsonPropertyName("artifacts_expire_at")]
    public DateTime ArtifactsExpireAt { get; set; }

    [JsonPropertyName("commit")]
    public Commit Commit { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("duration")]
    public double Duration { get; set; }

    [JsonPropertyName("finished_at")]
    public DateTime? FinishedAt { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("pipeline")]
    public Pipeline Pipeline { get; set; }

    [JsonPropertyName("ref")]
    public string Ref { get; set; }

    [JsonPropertyName("runner")]
    public Runner Runner { get; set; }

    [JsonPropertyName("stage")]
    public string Stage { get; set; }

    [JsonPropertyName("started_at")]
    public DateTime? StartedAt { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }
}
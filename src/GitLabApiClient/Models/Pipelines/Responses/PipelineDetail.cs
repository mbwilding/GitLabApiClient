using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Pipelines.Responses;

public class PipelineDetail
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("sha")]
    public string Sha { get; set; }

    [JsonPropertyName("ref")]
    public string Ref { get; set; }

    [JsonPropertyName("status")]
    public PipelineStatus Status { get; set; }

    [JsonPropertyName("web_url")]
    public Uri WebUrl { get; set; }

    [JsonPropertyName("before_sha")]
    public string BeforeSha { get; set; }

    [JsonPropertyName("tag")]
    public bool Tag { get; set; }

    [JsonPropertyName("yaml_errors")]
    public string YamlErrors { get; set; }

    [JsonPropertyName("user")]
    public PipelineUser User { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("started_at")]
    public DateTime? StartedAt { get; set; }

    [JsonPropertyName("finished_at")]
    public DateTime? FinishedAt { get; set; }

    [JsonPropertyName("committed_at")]
    public DateTime? CommittedAt { get; set; }

    [JsonPropertyName("duration")]
    public int Duration { get; set; }

    [JsonPropertyName("coverage")]
    public string Coverage { get; set; }
}
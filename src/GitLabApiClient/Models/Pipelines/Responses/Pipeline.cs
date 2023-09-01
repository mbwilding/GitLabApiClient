using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Pipelines.Responses;

public class Pipeline
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("status")]
    public PipelineStatus Status { get; set; }

    [JsonPropertyName("ref")]
    public string Ref { get; set; }

    [JsonPropertyName("sha")]
    public string Sha { get; set; }

    [JsonPropertyName("web_url")]
    public Uri WebUrl { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}
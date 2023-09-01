using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Pipelines.Responses;

public class PipelineUser
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("avatar_url")]
    public Uri AvatarUrl { get; set; }

    [JsonPropertyName("web_url")]
    public Uri WebUrl { get; set; }
}
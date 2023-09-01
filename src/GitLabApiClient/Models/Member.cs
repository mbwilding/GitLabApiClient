using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models;

public sealed class Member
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("access_level")]
    public int AccessLevel { get; set; }

    [JsonPropertyName("expires_at")]
    public DateTime ExpiresAt { get; set; }
}
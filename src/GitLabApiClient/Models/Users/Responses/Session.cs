using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Users.Responses;

public sealed class Session
{
    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("can_create_project")]
    public bool CanCreateProject { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("can_create_group")]
    public bool CanCreateGroup { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("color_scheme_id")]
    public int ColorSchemeId { get; set; }

    [JsonPropertyName("current_sign_in_at")]
    public string CurrentSignInAt { get; set; }

    [JsonPropertyName("linkedin")]
    public string Linkedin { get; set; }

    [JsonPropertyName("skype")]
    public string Skype { get; set; }

    [JsonPropertyName("identities")]
    public List<Identity> Identities { get; } = new();

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("is_admin")]
    public bool IsAdmin { get; set; }

    [JsonPropertyName("private_token")]
    public string PrivateToken { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("projects_limit")]
    public int ProjectsLimit { get; set; }

    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("two_factor_enabled")]
    public bool TwoFactorEnabled { get; set; }

    [JsonPropertyName("website_url")]
    public string WebsiteUrl { get; set; }
}
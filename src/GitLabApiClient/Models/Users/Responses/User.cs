using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Users.Responses;

public sealed class User
{
    [JsonPropertyName("current_sign_in_at")]
    public string CurrentSignInAt { get; set; }

    [JsonPropertyName("linkedin")]
    public string Linkedin { get; set; }

    [JsonPropertyName("can_create_project")]
    public bool CanCreateProject { get; set; }

    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("can_create_group")]
    public bool CanCreateGroup { get; set; }

    [JsonPropertyName("confirmed_at")]
    public string ConfirmedAt { get; set; }

    [JsonPropertyName("color_scheme_id")]
    public int ColorSchemeId { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("identities")]
    public List<Identity> Identities { get; } = new();

    [JsonPropertyName("external")]
    public bool External { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("last_activity_on")]
    public string LastActivityOn { get; set; }

    [JsonPropertyName("is_admin")]
    public bool IsAdmin { get; set; }

    [JsonPropertyName("last_sign_in_at")]
    public string LastSignInAt { get; set; }

    [JsonPropertyName("projects_limit")]
    public int ProjectsLimit { get; set; }

    [JsonPropertyName("two_factor_enabled")]
    public bool TwoFactorEnabled { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("skype")]
    public string Skype { get; set; }

    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("website_url")]
    public string WebsiteUrl { get; set; }
}
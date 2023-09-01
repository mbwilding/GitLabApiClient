using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Users.Requests;

/// <summary>
/// Modifies an existing user. Only administrators can change attributes of a user.
/// </summary>
public sealed class UpdateUserRequest
{
    /// <summary>
    /// Email.
    /// </summary>
    [JsonPropertyName("email")]
    public string Email { get; set; }

    /// <summary>
    /// Password.
    /// </summary>
    [JsonPropertyName("password")]
    public string Password { get; set; }

    /// <summary>
    /// Username.
    /// </summary>
    [JsonPropertyName("username")]
    public string Username { get; set; }

    /// <summary>
    /// Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Skype ID.
    /// </summary>
    [JsonPropertyName("skype")]
    public string Skype { get; set; }

    /// <summary>
    /// LinkedIn account.
    /// </summary>
    [JsonPropertyName("linkedin")]
    public string Linkedin { get; set; }

    /// <summary>
    /// Twitter account.
    /// </summary>
    [JsonPropertyName("twitter")]
    public string Twitter { get; set; }

    /// <summary>
    /// Website URL.
    /// </summary>
    [JsonPropertyName("website_url")]
    public string WebSiteUrl { get; set; }

    /// <summary>
    /// Organization name.
    /// </summary>
    [JsonPropertyName("organization")]
    public string Organization { get; set; }

    /// <summary>
    /// Limit projects each user can create.
    /// </summary>
    [JsonPropertyName("projects_limit")]
    public int? ProjectsLimit { get; set; }

    /// <summary>
    /// External UID.
    /// </summary>
    [JsonPropertyName("extern_uid")]
    public string ExternUid { get; set; }

    /// <summary>
    /// External provider name.
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }

    /// <summary>
    /// User's biography.
    /// </summary>
    [JsonPropertyName("bio")]
    public string Bio { get; set; }

    /// <summary>
    /// User's location.
    /// </summary>
    [JsonPropertyName("location")]
    public string Location { get; set; }

    /// <summary>
    /// User is admin.
    /// </summary>
    [JsonPropertyName("admin")]
    public bool? Admin { get; set; }

    /// <summary>
    /// User can create groups.
    /// </summary>
    [JsonPropertyName("can_create_group")]
    public bool? CanCreateGroup { get; set; }

    /// <summary>
    /// Flags the user as external.
    /// </summary>
    [JsonPropertyName("skip_confirmation")]
    public bool? SkipConfirmation { get; set; }

    /// <summary>
    /// Flags the user as external.
    /// </summary>
    [JsonPropertyName("external")]
    public bool? External { get; set; }
}
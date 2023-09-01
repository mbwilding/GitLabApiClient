using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Oauth.Requests;

public class AccessTokenRequest
{
    [JsonPropertyName("grant_type")]
    public string GrantType { get; set; }

    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }
}
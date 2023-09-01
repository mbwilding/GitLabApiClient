using System;
using System.Text.Json.Serialization;
using GitLabApiClient.Internal.Http.Serialization;

namespace GitLabApiClient.Models.Oauth.Responses;

public class AccessTokenResponse
{
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    [JsonPropertyName("token_type")]
    public string TokenType { get; set; }

    [JsonPropertyName("refresh_token")]
    public string RefreshToken { get; set; }

    [JsonPropertyName("scope")]
    public string Scope { get; set; }

    [JsonPropertyName("created_at")]
    [JsonConverter(typeof(UnixDateTimeConverter))]
    public DateTime? CreatedAt { get; set; }
}
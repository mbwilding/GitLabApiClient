using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Issues.Responses;

public sealed class ClosedBy : ModifiableObject
{
    [JsonPropertyName("active")]
    public string State;

    [JsonPropertyName("web_url")]
    public string WebUrl;

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl;

    [JsonPropertyName("username")]
    public string Username;

    [JsonPropertyName("name")]
    public string Name;
}
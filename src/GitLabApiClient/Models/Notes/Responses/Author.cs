using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Notes.Responses;

public sealed class Author
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }
}
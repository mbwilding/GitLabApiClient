using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Branches.Responses;

public sealed class PushAccessLevel
{
    [JsonPropertyName("access_level")]
    public ProtectedRefAccessLevels AccessLevel { get; set; }

    [JsonPropertyName("access_level_description")]
    public string AccessLevelDescription { get; set; }
}
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class Access
{
    [JsonPropertyName("access_level")]
    public int AccessLevel { get; set; }

    [JsonPropertyName("notification_level")]
    public int NotificationLevel { get; set; }
}
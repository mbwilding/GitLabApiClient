using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class Permissions
{
    [JsonPropertyName("group_access")]
    public Access GroupAccess { get; set; }

    [JsonPropertyName("project_access")]
    public Access ProjectAccess { get; set; }
}
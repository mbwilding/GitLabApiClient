using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Branches.Responses;

public sealed class ProtectedBranch
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("push_access_levels")]
    public PushAccessLevel[] PushAccessLevels { get; set; }

    [JsonPropertyName("merge_access_levels")]
    public PushAccessLevel[] MergeAccessLevels { get; set; }
}
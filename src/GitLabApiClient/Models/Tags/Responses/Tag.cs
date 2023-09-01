using GitLabApiClient.Models.Releases.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Tags.Responses;

public sealed class Tag
{
    [JsonPropertyName("commit")]
    public Commit Commit { get; set; }

    [JsonPropertyName("release")]
    public Release Release { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("target")]
    public string Target { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

}
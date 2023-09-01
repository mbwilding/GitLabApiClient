using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Runners.Responses;

public sealed class RunnerToken
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("token")]
    public string Token { get; set; }
}
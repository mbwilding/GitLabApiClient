using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Users.Responses;

public sealed class Identity
{
    [JsonPropertyName("extern_uid")]
    public string ExternUid { get; set; }

    [JsonPropertyName("provider")]
    public string Provider { get; set; }
}
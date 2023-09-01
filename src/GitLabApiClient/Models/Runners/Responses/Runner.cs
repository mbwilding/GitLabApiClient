using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Runners.Responses;

public sealed class Runner
{
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("is_shared")]
    public bool IsShared { get; set; }

    [JsonPropertyName("ip_address")]
    public string IpAddresses { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("online")]
    public bool Online { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }
}
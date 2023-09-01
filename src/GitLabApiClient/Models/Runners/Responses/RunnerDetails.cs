using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Runners.Responses;

public sealed class RunnerDetails
{
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    [JsonPropertyName("architecture")]
    public string Architecture { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("ip_address")]
    public string IpAddresses { get; set; }

    [JsonPropertyName("is_shared")]
    public bool IsShared { get; set; }

    [JsonPropertyName("contacted_at")]
    public string ContactedAt { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("online")]
    public bool Online { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    [JsonPropertyName("projects")]
    public List<RunnerProject> Projects { get; } = new();

    [JsonPropertyName("revision")]
    public string Revision { get; set; }

    [JsonPropertyName("tag_list")]
    public List<string> TagList { get; } = new();

    [JsonPropertyName("version")]
    public string Version { get; set; }

    [JsonPropertyName("access_level")]
    public string AccessLevel { get; set; }

    [JsonPropertyName("maximum_timeout")]
    public int MaximumTimeout { get; set; }
}
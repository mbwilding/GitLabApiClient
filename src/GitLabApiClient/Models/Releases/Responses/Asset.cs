using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Releases.Responses;

public sealed class Asset
{
    [JsonPropertyName("count")]
    public int Count { get; set; }

    [JsonPropertyName("sources")]
    public Source[] Sources { get; set; }

    [JsonPropertyName("links")]
    public Link[] Links { get; set; }
}
using System;
using GitLabApiClient.Models.Milestones.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Releases.Responses;

public class Release
{
    [JsonPropertyName("tag_name")]
    public string TagName { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("name")]
    public string ReleaseName { get; set; }

    [JsonPropertyName("description_html")]
    public string DescriptionHtml { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("released_at")]
    public DateTime? ReleasedAt { get; set; }

    [JsonPropertyName("author")]
    public Member Author { get; set; }

    [JsonPropertyName("commit")]
    public Commit Commit { get; set; }

    [JsonPropertyName("milestone")]
    public Milestone Milestone { get; set; }

    [JsonPropertyName("assets")]
    public Asset Assets { get; set; }
}
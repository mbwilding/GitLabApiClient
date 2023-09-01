using System;
using System.Text.Json.Serialization;

using GitLabApiClient.Models.Users.Responses;

namespace GitLabApiClient.Models.AwardEmojis.Responses;

public sealed class AwardEmoji
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("user")]
    public User User { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("awardable_id")]
    public int AwardableId { get; set; }

    [JsonPropertyName("awardable_type")]
    public AwardableType AwardableType { get; set; }

}
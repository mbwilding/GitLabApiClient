using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Notes.Responses;

public sealed class Position
{
    [JsonPropertyName("base_sha")]
    public string BaseSha { get; set; }

    [JsonPropertyName("start_sha")]
    public string StartSha { get; set; }

    [JsonPropertyName("head_sha")]
    public string HeadSha { get; set; }

    [JsonPropertyName("position_type")]
    public PositionType PositionType { get; set; }

    [JsonPropertyName("old_path")]
    public string OldPath { get; set; }

    [JsonPropertyName("new_path")]
    public string NewPath { get; set; }

    [JsonPropertyName("old_line")]
    public int? OldLine { get; set; }

    [JsonPropertyName("new_line")]
    public int? NewLine { get; set; }

}
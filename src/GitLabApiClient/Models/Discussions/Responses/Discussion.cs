using System.Collections.Generic;
using GitLabApiClient.Models.Notes.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Discussions.Responses;

public sealed class Discussion
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("individual_note")]
    public bool IndividualNote { get; set; }

    [JsonPropertyName("notes")]
    public IList<Note> Notes { get; set; } = new List<Note>();

}
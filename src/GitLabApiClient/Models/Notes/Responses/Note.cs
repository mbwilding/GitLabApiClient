using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Notes.Responses;

public sealed class Note : ModifiableObject
{
    [JsonPropertyName("noteable_id")]
    public int NoteableId { get; set; }

    [JsonPropertyName("noteable_iid")]
    public int NoteableIid { get; set; }

    [JsonPropertyName("noteable_type")]
    public string NoteableType { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }

    [JsonPropertyName("author")]
    public Author Author { get; set; }

    [JsonPropertyName("system")]
    public bool System { get; set; }

    [JsonPropertyName("resolvable")]
    public bool Resolvable { get; set; }

    [JsonPropertyName("resolved")]
    public bool? Resolved { get; set; }

    [JsonPropertyName("resolved_by")]
    public Author ResolvedBy { get; set; }

    [JsonPropertyName("position")]
    public Position Position { get; set; }

}
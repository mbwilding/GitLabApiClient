using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models;

public class ModifiableObject
{
    internal ModifiableObject() { }

    [JsonPropertyName("iid")]
    public int Iid { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
}
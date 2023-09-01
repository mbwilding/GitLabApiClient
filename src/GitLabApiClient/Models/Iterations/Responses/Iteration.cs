using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Iterations.Responses;

public sealed class Iteration : ModifiableObject
{
    public string Title { get; set; }

    [JsonPropertyName("group_id")]
    public int GroupId { get; set; }

    public string Description { get; set; }

    public IterationState State { get; set; }

    [JsonPropertyName("due_date")]
    public DateTime DueDate { get; set; }

    [JsonPropertyName("start_date")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("web_url")]
    public Uri WebUrl { get; set; }
}
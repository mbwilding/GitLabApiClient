using System;
using System.Collections.Generic;
using GitLabApiClient.Internal.Http.Serialization;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Issues.Requests;

/// <summary>
/// Used to update issues in a project.
/// </summary>
public sealed class UpdateIssueRequest
{
    /// <summary>
    /// The title of an issue.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// The description of an issue.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Updates an issue to be confidential.
    /// </summary>
    [JsonPropertyName("confidential")]
    public bool? Confidential { get; set; }

    /// <summary>
    /// The ID of the users to assign the issue to.
    /// </summary>
    [JsonPropertyName("assignee_ids")]
    public List<int> Assignees { get; set; } = new();

    /// <summary>
    /// The ID of a milestone to assign the issue to.
    /// </summary>
    [JsonPropertyName("milestone_id")]
    public int? MilestoneId { get; set; }

    /// <summary>
    /// Label names for an issue.
    /// </summary>
    [JsonPropertyName("labels")]
    [JsonConverter(typeof(CollectionToCommaSeparatedValuesConverter))]
    public IList<string> Labels { get; set; } = new List<string>();

    /// <summary>
    /// The state event of an issue. Set close to close the issue and reopen to reopen it.
    /// </summary>
    [JsonPropertyName("state_event")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public UpdatedIssueState? State { get; set; }

    /// <summary>
    /// Date time string, ISO 8601 formatted, e.g. 2016-03-11T03:45:40Z (requires admin or project owner rights).
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Date time string in the format YEAR-MONTH-DAY, e.g. 2016-03-11.
    /// </summary>
    [JsonPropertyName("due_date")]
    public string DueDate { get; set; }

    /// <summary>
    /// The weight of an issue. Valid values are greater than or equal to 0.
    /// </summary>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}
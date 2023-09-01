using GitLabApiClient.Models.Milestones.Requests;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Groups.Requests;

/// <summary>
/// Updates an existing group milestone.
/// </summary>
public sealed class UpdateGroupMilestoneRequest
{
    /// <summary>
    /// The title of a milestone.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// The description of the milestone
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// The due date of the milestone. Date time string in the format YEAR-MONTH-DAY, e.g. 2016-03-11.
    /// </summary>
    [JsonPropertyName("due_date")]
    public string DueDate { get; set; }

    /// <summary>
    /// The start date of the milestone. Date time string in the format YEAR-MONTH-DAY, e.g. 2016-03-11.
    /// </summary>
    [JsonPropertyName("start_date")]
    public string StartDate { get; set; }

    /// <summary>
    /// The state event of the milestone (close, active)
    /// </summary>
    [JsonPropertyName("state_event")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public UpdatedMilestoneState? State { get; set; }
}
using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Requests;

/// <summary>
/// Used to create milestones in a project.
/// </summary>
public sealed class CreateProjectMilestoneRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateProjectMilestoneRequest"/> class.
    /// </summary>
    /// <param name="title">The title of a milestone.</param>
    public CreateProjectMilestoneRequest(string title)
    {
        Guard.NotEmpty(title, nameof(title));
        Title = title;
    }

    /// <summary>
    /// The title of a milestone.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; private set; }

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
}
using System.Collections.Generic;
using GitLabApiClient.Internal.Http.Serialization;
using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.MergeRequests.Requests;

/// <summary>
/// Used to create merge request.
/// </summary>
public sealed class CreateMergeRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateMergeRequest"/> class.
    /// </summary>
    /// <param name="sourceBranch">The source branch.</param>
    /// <param name="targetBranch">The target branch.</param>
    /// <param name="title">Title of the merge request.</param>
    public CreateMergeRequest(string sourceBranch, string targetBranch, string title)
    {
        Guard.NotEmpty(sourceBranch, nameof(sourceBranch));
        Guard.NotEmpty(targetBranch, nameof(targetBranch));
        Guard.NotEmpty(title, nameof(title));
        SourceBranch = sourceBranch;
        TargetBranch = targetBranch;
        Title = title;
    }

    /// <summary>
    /// The source branch.
    /// </summary>
    [JsonPropertyName("source_branch")]
    public string SourceBranch { get; }

    /// <summary>
    /// The target branch.
    /// </summary>
    [JsonPropertyName("target_branch")]
    public string TargetBranch { get; }

    /// <summary>
    /// Title of merge request.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; }

    /// <summary>
    /// Description of merge request.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Labels names for merge request.
    /// </summary>
    [JsonPropertyName("labels")]
    [JsonConverter(typeof(CollectionToCommaSeparatedValuesConverter))]
    public IList<string> Labels { get; set; } = new List<string>();

    /// <summary>
    /// The ID of a milestone.
    /// </summary>
    [JsonPropertyName("milestone_id")]
    public int? MilestoneId { get; set; }

    /// <summary>
    /// Assignee user ID.
    /// </summary>
    [JsonPropertyName("assignee_id")]
    public int? AssigneeId { get; set; }

    /// <summary>
    /// The target project id. Numeric.
    /// </summary>
    [JsonPropertyName("target_project_id")]
    public int? TargetProjectId { get; set; }

    /// <summary>
    /// Flag indicating if a merge request should remove the source branch when merging.
    /// </summary>
    [JsonPropertyName("remove_source_branch")]
    public bool? RemoveSourceBranch { get; set; }
}
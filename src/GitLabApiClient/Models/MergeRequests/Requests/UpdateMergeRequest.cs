using System.Collections.Generic;
using GitLabApiClient.Internal.Http.Serialization;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.MergeRequests.Requests;

/// <summary>
/// Used to update merge request.
/// </summary>
public sealed class UpdateMergeRequest
{
    /// <summary>
    /// The target branch.
    /// </summary>
    [JsonPropertyName("target_branch")]
    public string TargetBranch { get; set; }

    /// <summary>
    /// Title of merge request.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// Description of merge request.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Assignee user ID.
    /// </summary>
    [JsonPropertyName("assignee_id")]
    public int? AssigneeId { get; set; }

    /// <summary>
    /// The ID of a milestone.
    /// </summary>
    [JsonPropertyName("milestone_id")]
    public int? MilestoneId { get; set; }

    /// <summary>
    /// Labels names for merge request.
    /// </summary>
    [JsonPropertyName("labels")]
    [JsonConverter(typeof(CollectionToCommaSeparatedValuesConverter))]
    public IList<string> Labels { get; set; } = new List<string>();

    [JsonPropertyName("state_event")]
    public RequestedMergeRequestState? State { get; set; }

    /// <summary>
    /// Flag indicating if a merge request should remove the source branch when merging.
    /// </summary>
    [JsonPropertyName("remove_source_branch")]
    public bool? RemoveSourceBranch { get; set; }
}
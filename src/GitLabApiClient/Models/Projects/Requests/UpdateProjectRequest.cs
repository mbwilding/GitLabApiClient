using System.Collections.Generic;
using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Requests;

/// <summary>
/// Updates an existing project.
/// </summary>
public sealed class UpdateProjectRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateProjectRequest"/> class.
    /// </summary>
    /// <param name="name">The name of the project.</param>
    public UpdateProjectRequest(string name)
    {
        Guard.NotEmpty(name, nameof(name));
        Name = name;
    }
    /// <summary>
    /// The name of the project.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; }

    /// <summary>
    /// Custom repository name for the project. By default generated based on name.
    /// </summary>
    [JsonPropertyName("path")]
    public string Path { get; set; }

    /// <summary>
    /// master by default.
    /// </summary>
    [JsonPropertyName("default_branch")]
    public string DefaultBranch { get; set; }

    /// <summary>
    /// Short project description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Enable issues for this project.
    /// </summary>
    [JsonPropertyName("issues_enabled")]
    public bool? EnableIssues { get; set; }

    /// <summary>
    /// Enable merge requests for this project.
    /// </summary>
    [JsonPropertyName("merge_requests_enabled")]
    public bool? EnableMergeRequests { get; set; }

    /// <summary>
    /// Enable jobs for this project.
    /// </summary>
    [JsonPropertyName("jobs_enabled")]
    public bool? EnableJobs { get; set; }

    /// <summary>
    /// Enable wiki for this project.
    /// </summary>
    [JsonPropertyName("wiki_enabled")]
    public bool? EnableWiki { get; set; }

    /// <summary>
    /// Enable snippets for this project.
    /// </summary>
    [JsonPropertyName("snippets_enabled")]
    public bool? EnableSnippets { get; set; }

    /// <summary>
    /// Enable container registry for this project.
    /// </summary>
    [JsonPropertyName("container_registry_enabled")]
    public bool? EnableContainerRegistry { get; set; }

    /// <summary>
    /// Enable shared runners for this project.
    /// </summary>
    [JsonPropertyName("shared_runners_enabled")]
    public bool? EnableSharedRunners { get; set; }

    /// <summary>
    /// Project visibility level.
    /// </summary>
    [JsonPropertyName("visibility")]
    public ProjectVisibilityLevel? Visibility { get; set; }

    /// <summary>
    /// URL to import repository from.
    /// </summary>
    [JsonPropertyName("import_url")]
    public string ImportUrl { get; set; }

    /// <summary>
    /// If set, jobs can be viewed by non-project-members.
    /// </summary>
    [JsonPropertyName("public_jobs")]
    public bool? PublicJobs { get; set; }

    /// <summary>
    /// Set whether merge requests can only be merged with successful jobs.
    /// </summary>
    [JsonPropertyName("only_allow_merge_if_pipeline_succeeds")]
    public bool? OnlyAllowMergeIfPipelineSucceeds { get; set; }

    /// <summary>
    /// Set whether merge requests can only be merged when all the discussions are resolved.
    /// </summary>
    [JsonPropertyName("only_allow_merge_if_all_discussions_are_resolved")]
    public bool? OnlyAllowMergeIfAllDiscussionsAreResolved { get; set; }

    /// <summary>
    /// Enable LFS.
    /// </summary>
    [JsonPropertyName("lfs_enabled")]
    public bool? EnableLfs { get; set; }

    /// <summary>
    /// Allow users to request member access.
    /// </summary>
    [JsonPropertyName("request_access_enabled")]
    public bool? EnableRequestAccess { get; set; }

    /// <summary>
    /// The list of tags for a project; put array of tags, that should be finally assigned to a project.
    /// </summary>
    [JsonPropertyName("tag_list")]
    public List<string> Tags { get; set; } = new();

    /// <summary>
    /// The path to CI config file.
    /// </summary>
    [JsonPropertyName("ci_config_path")]
    public string CiConfigPath { get; set; }
}
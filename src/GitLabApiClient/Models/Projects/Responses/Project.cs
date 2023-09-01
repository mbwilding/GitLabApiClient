using System;
using System.Collections.Generic;
using GitLabApiClient.Models.Projects.Requests;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class Project
{
    [JsonPropertyName("last_activity_at")]
    public DateTime LastActivityAt { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("container_registry_enabled")]
    public bool ContainerRegistryEnabled { get; set; }

    [JsonPropertyName("archived")]
    public bool Archived { get; set; }

    [JsonPropertyName("_links")]
    public Links Links { get; set; }

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("creator_id")]
    public int? CreatorId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("default_branch")]
    public string DefaultBranch { get; set; }

    [JsonPropertyName("import_error")]
    public string ImportError { get; set; }

    [JsonPropertyName("http_url_to_repo")]
    public string HttpUrlToRepo { get; set; }

    [JsonPropertyName("forks_count")]
    public int ForksCount { get; set; }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("issues_enabled")]
    public bool IssuesEnabled { get; set; }

    [JsonPropertyName("import_status")]
    public string ImportStatus { get; set; }

    [JsonPropertyName("jobs_enabled")]
    public bool JobsEnabled { get; set; }

    [JsonPropertyName("owner")]
    public Owner Owner { get; set; }

    [JsonPropertyName("namespace")]
    public Namespace Namespace { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("merge_requests_enabled")]
    public bool MergeRequestsEnabled { get; set; }

    [JsonPropertyName("name_with_namespace")]
    public string NameWithNamespace { get; set; }

    [JsonPropertyName("only_allow_merge_if_pipeline_succeeds")]
    public bool? OnlyAllowMergeIfPipelineSucceeds { get; set; }

    [JsonPropertyName("only_allow_merge_if_all_discussions_are_resolved")]
    public bool? OnlyAllowMergeIfAllDiscussionsAreResolved { get; set; }

    [JsonPropertyName("open_issues_count")]
    public int OpenIssuesCount { get; set; }

    [JsonPropertyName("public_jobs")]
    public bool PublicJobs { get; set; }

    [JsonPropertyName("path_with_namespace")]
    public string PathWithNamespace { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("permissions")]
    public Permissions Permissions { get; set; }

    [JsonPropertyName("runners_token")]
    public string RunnersToken { get; set; }

    [JsonPropertyName("request_access_enabled")]
    public bool RequestAccessEnabled { get; set; }

    [JsonPropertyName("shared_runners_enabled")]
    public bool SharedRunnersEnabled { get; set; }

    [JsonPropertyName("statistics")]
    public Statistics Statistics { get; set; }

    [JsonPropertyName("ssh_url_to_repo")]
    public string SshUrlToRepo { get; set; }

    [JsonPropertyName("snippets_enabled")]
    public bool SnippetsEnabled { get; set; }

    [JsonPropertyName("star_count")]
    public int StarCount { get; set; }

    [JsonPropertyName("visibility")]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ProjectVisibilityLevel Visibility { get; set; }

    [JsonPropertyName("tag_list")]
    public List<string> TagList { get; } = new();

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("wiki_enabled")]
    public bool WikiEnabled { get; set; }
}
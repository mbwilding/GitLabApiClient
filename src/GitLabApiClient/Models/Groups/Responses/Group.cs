using System.Collections.Generic;
using GitLabApiClient.Models.Groups.Requests;
using GitLabApiClient.Models.Projects.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Groups.Responses;

public sealed class Group
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("visibility")]
    public GroupsVisibility Visibility { get; set; }

    [JsonPropertyName("lfs_enabled")]
    public bool LfsEnabled { get; set; }

    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonPropertyName("web_url")]
    public string WebUrl { get; set; }

    [JsonPropertyName("request_access_enabled")]
    public bool RequestAccessEnabled { get; set; }

    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    [JsonPropertyName("full_path")]
    public string FullPath { get; set; }

    [JsonPropertyName("parent_id")]
    public int? ParentId { get; set; }

    [JsonPropertyName("projects")]
    public IList<Project> Projects { get; } = new List<Project>();
}
using System;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Releases.Requests;

/// <summary>
/// Used to update releases in a project
/// </summary>
public sealed class UpdateReleaseRequest
{
    [JsonPropertyName("name")]
    public string ReleaseName { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("released_at")]
    public DateTime? ReleasedAt { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateReleaseRequest"/> class
    /// </summary>
    /// <param name="releaseName">The name for the release</param>
    /// <param name="tagName">The name of the tag, the release will be created from</param>
    /// <param name="description">The description for the release.</param>
    /// <param name="releasedAt">The date the release will be/was ready.</param>
    public UpdateReleaseRequest(string releaseName, string description, DateTime? releasedAt = null)
    {
        ReleaseName = releaseName;
        Description = description;
        ReleasedAt = releasedAt;
    }
}
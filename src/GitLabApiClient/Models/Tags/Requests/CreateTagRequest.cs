using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Tags.Requests;

/// <summary>
/// Used to create a tag in a project.
/// </summary>
public sealed class CreateTagRequest
{
    /// <summary>
    /// Name for the created tag
    /// </summary>
    [JsonPropertyName("tag_name")]
    public string TagName { get; set; }

    /// <summary>
    /// Tag reference.
    /// </summary>
    [JsonPropertyName("ref")]
    public string Reference { get; set; }

    /// <summary>
    /// Annotated message.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Release notes.
    /// </summary>
    [JsonPropertyName("release_description")]
    public string ReleaseDescription { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateTagRequest"/> class.
    /// </summary>
    /// <param name="tagName">The name of the tag the release correspons to.</param>
    /// <param name="reference">Commit SHA, another tag name, or branh name.</param>
    /// <param name="message">Annotated message</param>
    /// <param name="releaseDescription">Release notes</param>
    public CreateTagRequest(string tagName, string reference, string message, string releaseDescription)
    {
        Guard.NotEmpty(tagName, nameof(tagName));
        Guard.NotEmpty(reference, nameof(reference));

        TagName = tagName;
        Reference = reference;
        Message = message;
        ReleaseDescription = releaseDescription;
    }
}
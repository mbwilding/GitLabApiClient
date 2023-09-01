using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Branches.Requests;

/// <summary>
/// Creates a new branch on a project.
/// </summary>
public sealed class CreateBranchRequest
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateBranchRequest"/> class
    /// </summary>
    /// <param name="branch">Name of the Branch.</param>
    /// <param name="reference">Branch name or commit SHA to create branch from.</param>
    public CreateBranchRequest(string branch, string reference)
    {
        Guard.NotEmpty(branch, nameof(branch));
        Guard.NotEmpty(reference, nameof(reference));
        Branch = branch;
        Reference = reference;
    }

    /// <summary>
    /// Branch Name.
    /// </summary>
    [JsonPropertyName("branch")]
    public string Branch { get; set; }

    /// <summary>
    /// Branch Reference.
    /// </summary>
    [JsonPropertyName("ref")]
    public string Reference { get; set; }

}
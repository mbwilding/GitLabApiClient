using System.Collections.Generic;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Commits.Requests.CreateCommitRequest;

public class CreateCommitRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateCommitRequest"/> class.
    /// </summary>
    /// <param name="branch">Name of the branch</param>
    /// <param name="commitMessage">Commit message</param>
    /// <param name="actions">File actions, see <see cref="CreateCommitRequestAction"/></param>
    public CreateCommitRequest(string branch, string commitMessage, List<CreateCommitRequestAction> actions)
    {
        Guard.NotEmpty(branch, nameof(branch));
        Guard.NotEmpty(commitMessage, nameof(commitMessage));
        Guard.NotEmpty(actions, nameof(actions));

        Branch = branch;
        CommitMessage = commitMessage;
        Actions = actions;
        //Default of GitLab
        Stats = true;
    }

    /// <summary>
    /// Name of the branch to commit into. To create a new branch, also provide either StartBranch or StartSha, and optionally StartProject.
    /// </summary>
    [JsonPropertyName("branch")]
    public string Branch { get; set; }

    /// <summary>
    /// Commit message
    /// </summary>
    [JsonPropertyName("commit_message")]
    public string CommitMessage { get; set; }

    /// <summary>
    /// Name of the branch to start the new branch from.
    /// </summary>
    [JsonPropertyName("start_branch")]
    public string StartBranch { get; set; }

    /// <summary>
    /// SHA of the commit to start the new branch from.
    /// </summary>
    [JsonPropertyName("start_sha")]
    public string StartSha { get; set; }

    /// <summary>
    /// The project ID or URL-encoded path of the project to start the new branch from. Defaults to the value of id.
    /// See <see cref="ProjectId"/>.
    /// </summary>
    [JsonPropertyName("start_project")]
    public ProjectId StartProjectId { get; set; }

    /// <summary>
    /// A list of action hashes to commit as a batch. See <see cref="CreateCommitRequestAction"/>.
    /// </summary>
    [JsonPropertyName("actions")]
    public List<CreateCommitRequestAction> Actions { get; set; }

    /// <summary>
    /// Specify the commit author’s email address.
    /// </summary>
    [JsonPropertyName("author_email")]
    public string AuthorEmail { get; set; }

    /// <summary>
    /// Specify the commit author’s name.
    /// </summary>
    [JsonPropertyName("author_name")]
    public string AuthorName { get; set; }

    /// <summary>
    /// Include commit stats. Default is true.
    /// </summary>
    [JsonPropertyName("stats")]
    public bool? Stats { get; set; }

    /// <summary>
    /// When true overwrites the target branch with a new commit based on the StartBranch or StartSha.
    /// </summary>
    [JsonPropertyName("force")]
    public bool? Force { get; set; }
}
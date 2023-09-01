using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Branches.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Branches.Requests;

/// <summary>
/// Protects a branch.
/// </summary>
public sealed class ProtectBranchRequest
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ProtectBranchRequest"/> class.
    /// </summary>
    /// <param name="name">The name of the branch or wildcard.</param>
    /// <param name="pushAccessLevel">Access levels allowed to push.</param>
    /// <param name="mergeAccessLevel">Access levels allowed to merge.</param>
    /// <param name="unprotectAccessLevel">Access levels allowed to unprotect.</param>
    public ProtectBranchRequest(
        string name,
        ProtectedRefAccessLevels? pushAccessLevel = ProtectedRefAccessLevels.MaintainerAccess,
        ProtectedRefAccessLevels? mergeAccessLevel = ProtectedRefAccessLevels.MaintainerAccess,
        ProtectedRefAccessLevels? unprotectAccessLevel = ProtectedRefAccessLevels.MaintainerAccess)
    {
        Guard.NotEmpty(name, nameof(name));

        PushAccessLevel = pushAccessLevel.ToString();
        MergeAccessLevel = mergeAccessLevel.ToString();
        UnprotectAccessLevel = unprotectAccessLevel.ToString();
    }

    /// <summary>
    /// The name of the branch or wildcard.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Access levels allowed to push (defaults: 40, maintainer access level).
    /// </summary>
    [JsonPropertyName("push_access_level")]
    public string PushAccessLevel { get; set; }

    /// <summary>
    /// Access levels allowed to merge (defaults: 40, maintainer access level).
    /// </summary>
    [JsonPropertyName("merge_access_level")]
    public string MergeAccessLevel { get; set; }

    /// <summary>
    /// Access levels allowed to unprotect (defaults: 40, maintainer access level).
    /// </summary>
    [JsonPropertyName("unprotect_access_level")]
    public string UnprotectAccessLevel { get; set; }
}
using GitLabApiClient.Internal.Utilities;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Groups.Requests;

/// <summary>
/// Used to create Ldap link requests to a group.
/// </summary>
public sealed class CreateLdapGroupLinkRequest
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateLdapGroupLinkRequest"/> class.
    /// </summary>
    /// <param name="cn">Minimum access level for members of the LDAP group.</param>
    /// <param name="groupAccess">The group's visibility.</param>
    /// <param name="provider">LDAP provider for the LDAP group (when using several providers).</param>
    public CreateLdapGroupLinkRequest(string cn, string groupAccess, string provider)
    {
        Guard.NotEmpty(cn, nameof(cn));
        Guard.NotEmpty(groupAccess, nameof(groupAccess));
        Guard.NotEmpty(provider, nameof(provider));
        Cn = cn;
        GroupAccess = groupAccess;
        Provider = provider;
    }

    /// <summary>
    /// The CN of a LDAP group
    /// </summary>
    [JsonPropertyName("cn")]
    public string Cn { get; }

    /// <summary>
    /// Minimum access level for members of the LDAP group
    /// </summary>
    [JsonPropertyName("group_access")]
    public string GroupAccess { get; }

    /// <summary>
    /// LDAP provider for the LDAP group (when using several providers)
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; }
}
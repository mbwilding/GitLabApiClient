using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Requests;

public class TransferProjectRequest
{
    /// <summary>
    /// The ID or path of the namespace to transfer to project to
    /// </summary>
    [JsonPropertyName("namespace")]
    public string NameSpace { get; set; }
}
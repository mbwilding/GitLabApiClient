using System.Collections.Generic;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Pipelines.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Pipelines.Requests;

public sealed class CreatePipelineRequest
{
    public CreatePipelineRequest(string reference, IList<PipelineVariable> variables = null)
    {
        Guard.NotEmpty(reference, nameof(reference));

        Reference = reference;

        Variables = variables ?? new List<PipelineVariable>();
    }

    /// <summary>
    ///     Reference to commit
    /// </summary>
    [JsonPropertyName("ref")]
    public string Reference { get; }

    /// <summary>
    ///     An array containing the variables available in the pipeline, matching the structure [{ 'key' => 'UPLOAD_TO_S3',
    ///     'variable_type' => 'file', 'value' => 'true' }]
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<PipelineVariable> Variables { get; }
}
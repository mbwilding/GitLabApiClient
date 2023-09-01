using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Pipelines.Responses;

public class PipelineVariable
{
    [JsonPropertyName("variable_type")]
    public PipelineVariableType VariableType { get; set; } = PipelineVariableType.Unknown;

    [JsonPropertyName("key")]
    public string Key { get; set; }

    [JsonPropertyName("value")]
    public string Value { get; set; }
}
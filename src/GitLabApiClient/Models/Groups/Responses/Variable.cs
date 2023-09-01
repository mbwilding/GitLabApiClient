using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Groups.Responses;

public sealed class Variable
{
    /// <summary>
    /// The type of a variable.
    /// Available types are: env_var (default) and file
    /// </summary>
    [JsonPropertyName("variable_type")]
    public string VariableType { get; set; }

    /// <summary>
    /// The key of a variable
    /// </summary>
    [JsonPropertyName("key")]
    public string Key { get; set; }

    /// <summary>
    /// The value of a variable
    /// </summary>
    [JsonPropertyName("value")]
    public string Value { get; set; }

    /// <summary>
    /// Whether the variable is protected
    /// </summary>
    [JsonPropertyName("protected")]
    public bool Protected { get; set; }

    /// <summary>
    /// Whether the variable is masked
    /// </summary>
    [JsonPropertyName("masked")]
    public bool Masked { get; set; }
}
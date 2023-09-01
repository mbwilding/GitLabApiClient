using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class ImportStatus
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("name_with_namespace")]
    public string NameWithNamespace { get; set; }

    [JsonPropertyName("path_with_namespace")]
    public string PathWithNamespace { get; set; }

    [JsonPropertyName("path")]
    public string Path { get; set; }

    [JsonPropertyName("import_status")]
    public ImportStatusEnum Status { get; set; }
}
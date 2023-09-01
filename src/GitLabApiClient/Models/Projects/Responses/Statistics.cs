using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.Projects.Responses;

public sealed class Statistics
{
    [JsonPropertyName("job_artifacts_size")]
    public int JobArtifactsSize { get; set; }

    [JsonPropertyName("repository_size")]
    public int RepositorySize { get; set; }

    [JsonPropertyName("commit_count")]
    public int CommitCount { get; set; }

    [JsonPropertyName("lfs_objects_size")]
    public int LfsObjectsSize { get; set; }

    [JsonPropertyName("storage_size")]
    public int StorageSize { get; set; }
}
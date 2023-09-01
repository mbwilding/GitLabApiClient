using System.Threading.Tasks;

using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Files.Responses;

namespace GitLabApiClient;

public interface IFilesClient
{
    Task<File> GetAsync(ProjectId projectId, string filePath, string reference = "master");
    Task<File> HeadAsync(ProjectId projectId, string filePath, string reference = "master");
    Task<bool> ExistsAsync(ProjectId projectId, string filePath, string reference = "master");
}
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models.Files.Responses;

namespace GitLabApiClient;

public sealed class FilesClient : IFilesClient
{
    private readonly GitLabHttpFacade _httpFacade;

    internal FilesClient(GitLabHttpFacade httpFacade) => _httpFacade = httpFacade;

    public async Task<File> HeadAsync(ProjectId projectId, string filePath, string reference = "master")
    {
        var url = $"projects/{projectId}/repository/files/{filePath.UrlEncode()}?ref={reference}";
        var response = await _httpFacade.Head(url);
        return new File(_httpFacade, url)
        {
            FileName = response.Headers.GetValues("X-Gitlab-File-Name").First(),
            FullPath = response.Headers.GetValues("X-Gitlab-File-Path").First(),
            Size = Convert.ToInt32(response.Headers.GetValues("X-Gitlab-Size").First()),
            Encoding = response.Headers.GetValues("X-Gitlab-Encoding").First(),
            ContentSha256 = response.Headers.GetValues("X-Gitlab-Content-Sha256").First(),
            Reference = response.Headers.GetValues("X-Gitlab-Ref").First(),
            BlobId = response.Headers.GetValues("X-Gitlab-Blob-Id").First(),
            CommitId = response.Headers.GetValues("X-Gitlab-Commit-Id").First(),
            LastCommitId = response.Headers.GetValues("X-Gitlab-Last-Commit-Id").First()
        };
    }

    public async Task<File> GetAsync(ProjectId projectId, string filePath, string reference = "master")
    {
        return await _httpFacade.Get<File>($"projects/{projectId}/repository/files/{filePath.UrlEncode()}?ref={reference}");
    }

    public async Task<bool> ExistsAsync(ProjectId projectId, string filePath, string reference = "master")
    {
        var response = await _httpFacade.Head($"projects/{projectId}/repository/files/{filePath.UrlEncode()}?ref={reference}");
        return response.StatusCode switch
        {
            HttpStatusCode.OK => true,
            HttpStatusCode.NotFound => false,
            _ => throw new GitLabException(response.StatusCode, "")
        };
    }
}
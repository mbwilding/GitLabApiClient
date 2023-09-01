using System;
using System.Text.Json.Serialization;
using GitLabApiClient.Internal.Http;

namespace GitLabApiClient.Models.Files.Responses;

public sealed class File
{
    private readonly GitLabHttpFacade? _httpFacade;
    private readonly string _url;

    public File(){}

    // Leaky abstraction, lazy loading the content
    public File(GitLabHttpFacade httpFacade, string url)
    {
        _httpFacade = httpFacade;
        _url = url;
    }

    [JsonPropertyName("file_name")]
    public string FileName { get; set; }

    [JsonPropertyName("file_path")]
    public string FullPath { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("encoding")]
    public string Encoding { get; set; }

    [JsonPropertyName("content_sha256")]
    public string ContentSha256 { get; set; }

    [JsonPropertyName("ref")]
    public string Reference { get; set; }

    [JsonPropertyName("blob_id")]
    public string BlobId { get; set; }

    [JsonPropertyName("commit_id")]
    public string CommitId { get; set; }

    [JsonPropertyName("last_commit_id")]
    public string LastCommitId { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    public string? ContentDecoded
    {
        get
        {
            if (Content == null)
            {
                var file = _httpFacade!.Get<File>(_url).GetAwaiter().GetResult();
                Content = file.Content;
                // FileName = file.FileName;
                // FullPath = file.FullPath;
                // Size = file.Size;
                // Encoding = file.Encoding;
                // ContentSha256 = file.ContentSha256;
                // Reference = file.Reference;
                // BlobId = file.BlobId;
                // CommitId = file.CommitId;
                // LastCommitId = file.LastCommitId;
            }

            return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(Content!));
        }
    }
}
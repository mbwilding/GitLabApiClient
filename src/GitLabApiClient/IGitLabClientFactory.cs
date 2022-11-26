namespace GitLabApiClient
{
    public interface IGitLabClientFactory
    {
        IGitLabClient CreateClient();
    }
}
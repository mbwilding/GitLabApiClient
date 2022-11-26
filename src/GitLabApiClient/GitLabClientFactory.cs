using System.Net.Http;

using Microsoft.Extensions.Options;

namespace GitLabApiClient
{
    public class GitLabClientFactory : IGitLabClientFactory
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly GitLabClientOptions _options;

        public GitLabClientFactory(IHttpClientFactory httpClientFactory, IOptions<GitLabClientOptions> options)
        {
            _httpClientFactory = httpClientFactory;
            _options = options.Value;
        }

        public IGitLabClient CreateClient()
        {
            return new GitLabClient(
                _options.HostUrl,
                _options.AuthenticationToken,
                _httpClientFactory.CreateClient(),
                _options.ClientTimeout);
        }
    }
}

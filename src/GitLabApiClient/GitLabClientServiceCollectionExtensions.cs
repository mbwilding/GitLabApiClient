using System;

using GitLabApiClient;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class GitLabClientServiceCollectionExtensions
    {
        public static IServiceCollection AddGitLabClient(
            this IServiceCollection services,
            string sectionKey = "gitLabClient")
        {
            services.AddOptions();
            var config = services.BuildServiceProvider().GetRequiredService<IConfiguration>(); ;
            services.Configure<GitLabClientOptions>(config.GetSection(sectionKey));

            services.AddHttpClient();
            services.TryAddSingleton<IGitLabClientFactory, GitLabClientFactory>();

            return services;
        }
    }
}

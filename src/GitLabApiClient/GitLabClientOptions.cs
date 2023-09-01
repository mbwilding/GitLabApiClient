using System;
using System.Collections.Generic;
using System.Text;

namespace GitLabApiClient;

public class GitLabClientOptions
{
    public string HostUrl { get; set; }
    public string AuthenticationToken { get; set; }
    public TimeSpan? ClientTimeout { get; internal set; }
}
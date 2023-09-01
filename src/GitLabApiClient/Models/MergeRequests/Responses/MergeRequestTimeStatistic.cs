using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.MergeRequests.Responses;

public class MergeRequestTimeStatistic
{
    [JsonPropertyName("time_estimate")]
    public int TimeEstimate { get; set; }

    [JsonPropertyName("total_time_spent")]
    public int TotalTimeSpent { get; set; }

    [JsonPropertyName("human_time_estimate")]
    public string HumanTimeEstimate { get; set; }

    [JsonPropertyName("human_total_time_spent")]
    public string HumanTotalTimeSpent { get; set; }
}
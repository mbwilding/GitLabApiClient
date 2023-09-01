using System;
using System.Text.Json;
using GitLabApiClient.Models.Issues.Responses;
using GitLabApiClient.Models.MergeRequests.Responses;
using GitLabApiClient.Models.Projects.Responses;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Models.ToDoList.Responses;

[JsonConverter(typeof(ToDoItemConverter))]
public interface IToDo
{
    int? Id { get; set; }
    Project Project { get; set; }
    Assignee Author { get; set; }
    ToDoActionType? ActionType { get; set; }
    ToDoTargetType? TargetType { get; set; }
    string TargetUrl { get; set; }
    string Body { get; set; }
    ToDoState? State { get; set; }
    string CreatedAt { get; set; }
}

public abstract class ToDo : IToDo
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("project")]
    public Project Project { get; set; }

    [JsonPropertyName("author")]
    public Assignee Author { get; set; }

    [JsonPropertyName("action_name")]
    public ToDoActionType? ActionType { get; set; }

    [JsonPropertyName("target_type")]
    public ToDoTargetType? TargetType { get; set; }

    [JsonPropertyName("target_url")]
    public string TargetUrl { get; set; }

    [JsonPropertyName("body")]
    public string Body { get; set; }

    [JsonPropertyName("state")]
    public ToDoState? State { get; set; }

    [JsonPropertyName("created_at")]
    public string CreatedAt { get; set; }
}

public sealed class ToDoIssue : ToDo
{
    [JsonPropertyName("target")]
    public Issue Target { get; set; }
}

public sealed class ToDoMergeRequest : ToDo
{
    [JsonPropertyName("target")]
    public MergeRequest Target { get; set; }
}

public class ToDoItemConverter : JsonConverter<IToDo>
{
    public override IToDo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            var root = doc.RootElement;
            if (root.TryGetProperty("target_type", out var typeProp))
            {
                var type = typeProp.GetString();

                IToDo target;
                switch (type)
                {
                    case "Issue":
                        target = JsonSerializer.Deserialize<ToDoIssue>(root.GetRawText());
                        break;

                    case "MergeRequest":
                        target = JsonSerializer.Deserialize<ToDoMergeRequest>(root.GetRawText());
                        break;

                    default:
                        throw new ApplicationException("ToDo target not supported.");
                }

                return target;
            }
            else
            {
                throw new JsonException("Expected target_type property.");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, IToDo value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, options);
    }
}
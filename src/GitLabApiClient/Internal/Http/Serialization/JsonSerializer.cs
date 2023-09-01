using System.Text.Json;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Internal.Http.Serialization;

public sealed class RequestsJsonSerializer
{
    private static readonly JsonSerializerOptions Settings;

    static RequestsJsonSerializer() => Settings = new JsonSerializerOptions
    {
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNameCaseInsensitive = true,
        AllowTrailingCommas = true,
        Converters =
        {
            new BoolStringConverter(),
            new StringNumberConverter()
        }
    };

    public string Serialize(object obj) => JsonSerializer.Serialize(obj, Settings);

    public T Deserialize<T>(string serializeJson) => JsonSerializer.Deserialize<T>(serializeJson, Settings)!;
}
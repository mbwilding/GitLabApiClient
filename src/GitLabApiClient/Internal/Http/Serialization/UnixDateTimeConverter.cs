using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Internal.Http.Serialization;

public class UnixDateTimeConverter : JsonConverter<DateTime?>
{
    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.Number)
        {
            throw new JsonException("Expected a number.");
        }

        long timestamp = reader.GetInt64();
        return DateTimeOffset.FromUnixTimeSeconds(timestamp).DateTime;
    }

    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
    {
        if (value.HasValue)
        {
            long timestamp = ((DateTimeOffset)value.Value).ToUnixTimeSeconds();
            writer.WriteNumberValue(timestamp);
        }
    }
}
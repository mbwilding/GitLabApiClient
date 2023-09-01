using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class BoolStringConverter : JsonConverter<bool>
{
    public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType is JsonTokenType.True or JsonTokenType.False)
        {
            return reader.GetBoolean();
        }

        if (reader.TokenType == JsonTokenType.String)
        {
            string stringValue = reader.GetString();
            if (bool.TryParse(stringValue, out bool boolValue))
            {
                return boolValue;
            }
            throw new JsonException($"Value '{stringValue}' cannot be converted to a boolean.");
        }

        throw new JsonException($"Unexpected token type: {reader.TokenType}.");
    }

    public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString().ToLower());
    }
}
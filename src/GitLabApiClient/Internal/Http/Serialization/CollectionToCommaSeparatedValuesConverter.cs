using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GitLabApiClient.Internal.Http.Serialization;

internal sealed class CollectionToCommaSeparatedValuesConverter : JsonConverter<IEnumerable<string>>
{
    public override IEnumerable<string> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        // Since we set this converter to write-only, we'll throw an exception here.
        throw new NotSupportedException();
    }

    public override void Write(Utf8JsonWriter writer, IEnumerable<string> value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(string.Join(",", value));
    }

    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert == typeof(IEnumerable<string>);
    }
}
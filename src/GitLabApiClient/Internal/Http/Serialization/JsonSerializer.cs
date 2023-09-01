using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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

    public async Task<T> DeserializeAsync<T>(Stream stream) =>
        (await JsonSerializer.DeserializeAsync<T>(stream, Settings))!;
}
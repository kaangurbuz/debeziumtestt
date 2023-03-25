using System.Text.Json.Serialization;

namespace Consumer.Models;

public class DebeziumModel<T>
{
    [JsonPropertyName("before")]
    public T Before { get; init; }

    [JsonPropertyName("after")]
    public T After { get; init; }
}

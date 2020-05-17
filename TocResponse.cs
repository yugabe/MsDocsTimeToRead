using System.Text.Json.Serialization;

namespace MsDocsTimeToRead
{
    public class TocResponse
    {
        [JsonPropertyName("items")]
        public Link[] Items { get; set; } = default!;
    }
}
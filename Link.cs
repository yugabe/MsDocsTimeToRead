using System.Linq;
using System.Text.Json.Serialization;

namespace MsDocsTimeToRead
{
    public class Link
    {
        [JsonPropertyName("toc_title")]
        public string Title { get; set; } = default!;
        [JsonPropertyName("href")]
        public string? Href { get; set; }
        [JsonPropertyName("monikers")]
        public string[]? Monikers { get; set; }
        [JsonPropertyName("children")]
        public Link[]? Children { get; set; }

        public int? TimeToRead { get; set; }

        public int? ChildrenTimeToRead => Children?.Flatten(c => c.Children).Sum(i => i.item.TimeToRead);
    }
}

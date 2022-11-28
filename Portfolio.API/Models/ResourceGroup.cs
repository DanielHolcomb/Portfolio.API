using System.Text.Json.Serialization;

namespace Portfolio.API.Models
{
    public class ResourceGroup
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}

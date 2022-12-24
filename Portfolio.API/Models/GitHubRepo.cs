using System.Text.Json.Serialization;

namespace Portfolio.API.Models
{
    public class GitHubRepo
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Portfolio.API.Models
{
    public class Resource
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type")]
        public string? Type { get; set; }

        [JsonPropertyName("nameSpace")]
        public string? NameSpace { get; set; }

        [JsonPropertyName("repoUri")]
        public string? RepoUri { get; set; }

        [JsonPropertyName("repoPath")]
        public string? RepoPath { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace Tier3.Networking.Utility
{
    public class NetworkPackage
    {
        [JsonPropertyName("type")]
        public string NetworkType { get; set; }
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
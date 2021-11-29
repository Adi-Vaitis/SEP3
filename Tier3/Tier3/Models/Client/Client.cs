using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier3.Models.Client
{
    public class Client
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("username"), Required]
        public string Username { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("password"), Required]
        public string Password { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("burials")]
        public IList<Burial.Burial> Burials { get; set; }
        
        [JsonIgnore]
        public IList<ClientBurial> ClientBurials { get; set; }
        [JsonIgnore]
        public IList<ClientPreference> ClientPreferences { get; set; }
    }
}
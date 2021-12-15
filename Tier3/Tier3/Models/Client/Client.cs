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
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [Required]
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("burials")]
        public IList<Burial.Burial> Burials { get; set; }
        
        [JsonIgnore]
        public IList<ClientBurial> ClientBurials { get; set; }
    }
}
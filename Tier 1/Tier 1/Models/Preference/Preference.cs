using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier3.Models.Preference
{
    public class Preference
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("burial"), Required]
        public int BurialId { get; set; }
        [JsonPropertyName("description"), Required]
        public string Description { get; set; }
        
    }
}
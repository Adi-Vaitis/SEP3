using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier_1.Models.Preference
{
    public class Preference
    {
        [JsonPropertyName("id"), Required]
        public int Id { get; set; }
        [JsonPropertyName("burial"), Required]
        public int BurialId { get; set; }
        [JsonPropertyName("description"), Required]
        public string Description { get; set; }

        public Preference(int id, int burialId, string description)
        {
            Id = id;
            BurialId = burialId;
            Description = description;
        }

        public Preference(int burialId, string description)
        {
            BurialId = burialId;
            Description = description;
        }

        public Preference()
        {
        }
    }
}
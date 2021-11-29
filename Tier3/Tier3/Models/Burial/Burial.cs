using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier3.Models.Burial
{
    public class Burial
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("preferences")]
        public IList<Preference.Preference> PreferenceForBurial { get; set; }
        [JsonPropertyName("location"), Required]
        public string Location { get; set; }
        [JsonPropertyName("date"), Required]
        public DateTime Date { get; set; }
        [JsonPropertyName("participants"), Required]
        public int NumberOfParticipants { get; set; }
        [JsonPropertyName("name"), Required]
        public string FullNameOfTheDeadMan { get; set; }
        [JsonPropertyName("client")]
        public Client.Client Client { get; set; }
        [JsonPropertyName("clientId")]
        public int ClientId { get; set; }
        [JsonPropertyName("comments")]
        public string Comments { get; set; }
        
        [JsonIgnore]
        public IList<BurialPreference> BurialPreferences { get; set; }
        [JsonIgnore]
        public IList<ClientBurial> ClientBurials { get; set; }
    }
}
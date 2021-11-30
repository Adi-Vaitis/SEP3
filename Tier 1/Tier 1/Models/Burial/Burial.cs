using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier_1.Models.Burial
{
    public class Burial
    {
        [JsonPropertyName("id"), Required]
        public int Id { get; set; }
        [JsonPropertyName("preferences"), Required]
        public IList<Preference.Preference> PreferenceForBurial { get; set; }
        [JsonPropertyName("location"), Required]
        public string Location { get; set; }
        [JsonPropertyName("date"), Required]
        public DateTime Date { get; set; }
        [JsonPropertyName("participants"), Required]
        public int NumberOfParticipants { get; set; }
        [JsonPropertyName("name"), Required]
        public string FullNameOfTheDeadMan { get; set; }
        [JsonPropertyName("clientId"), Required]
        public int ClientId { get; set; }
        [JsonPropertyName("comments")]
        public string Comments { get; set; }

        public Burial(IList<Preference.Preference> preferenceForBurial, int clientId)
        {
            PreferenceForBurial = preferenceForBurial;
            ClientId = clientId;
        }

        public Burial()
        {
        }
    }
}
namespace Tier3.Models
{
    public class ClientPreference
    {
        public int ClientId { get; set; }
        public Client.Client Client { get; set; }
        public int PreferenceId { get; set; }
        public Preference.Preference PreferenceClient { get; set; }
    }
}
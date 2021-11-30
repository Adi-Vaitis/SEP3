namespace Tier3.Models
{
    public class BurialPreference
    {
        public int BurialId { get; set; }
        public Burial.Burial Burial { get; set; }
        public int PreferenceId { get; set; }
        public Preference.Preference Preference { get; set; }
    }
}
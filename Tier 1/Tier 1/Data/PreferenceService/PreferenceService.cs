using System.Collections.Generic;
using System.Threading.Tasks;
using Tier_1.Models.Preference;

namespace Tier_1.Data.PreferenceService
{
    public class PreferenceService : IPreferenceService
    {
        public Task<IList<Preference>> GetPreferencesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task AddPreference(Preference preference)
        {
            throw new System.NotImplementedException();
        }
    }
}
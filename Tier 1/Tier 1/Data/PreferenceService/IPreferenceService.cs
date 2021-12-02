using System.Collections.Generic;
using System.Threading.Tasks;
using Tier_1.Models.Preference;

namespace Tier_1.Data.PreferenceService
{
    public interface IPreferenceService
    {
        Task<IList<Preference>> GetPreferencesAsync();
        Task AddPreference(Preference preference);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tier3.Repositories.Preference
{
    public interface IPreferenceRepo
    {
        Task CreatePreference(Models.Preference.Preference preference);
        Task<IList<Models.Preference.Preference>> GetPreference();
        Task EditPreference(Models.Preference.Preference preference);
        Task DeletePreference(int preferenceId);
        Task<Models.Preference.Preference> GetPreferenceById(int preferenceId);
        Task<IList<Models.Preference.Preference>> GetPreferenceByBurialId(int burialId);
    }
}
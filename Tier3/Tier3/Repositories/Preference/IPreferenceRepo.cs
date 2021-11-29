using System.Threading.Tasks;

namespace Tier3.Repositories.Preference
{
    public interface IPreferenceRepo
    {
        Task<string> CreatePreference(Models.Preference.Preference preference);
        Task<Models.Preference.Preference> GetPreference(int preferenceId);
        Task<string> EditPreference(Models.Preference.Preference preference);
        Task DeletePreference(int preferenceId);
        Task<Models.Preference.Preference> GetPreferenceById(int preferenceId);
        Task<Models.Preference.Preference> GetPreferenceByBurialId(int burialId);
    }
}
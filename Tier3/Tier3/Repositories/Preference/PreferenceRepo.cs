using System.Threading.Tasks;

namespace Tier3.Repositories.Preference
{
    public class PreferenceRepo : IPreferenceRepo
    {
        public Task<string> CreatePreference(Models.Preference.Preference preference)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Preference.Preference> GetPreference(int preferenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> EditPreference(Models.Preference.Preference preference)
        {
            throw new System.NotImplementedException();
        }

        public Task DeletePreference(int preferenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Preference.Preference> GetPreferenceById(int preferenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Preference.Preference> GetPreferenceByBurialId(int burialId)
        {
            throw new System.NotImplementedException();
        }
    }
}
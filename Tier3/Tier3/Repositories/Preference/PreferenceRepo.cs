using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tier3.DataAccess;
using Tier3.Models;

namespace Tier3.Repositories.Preference
{
    public class PreferenceRepo : IPreferenceRepo
    {
        private DataBaseContext dbCtx;
        private IList<Models.Preference.Preference> _preferences;

        public PreferenceRepo()
        {
            _preferences = new List<Models.Preference.Preference>();
        }
        
        public async Task CreatePreference(Models.Preference.Preference preference)
        {
            await using (dbCtx = new DataBaseContext())
            {
                preference.BurialPreferences = new Collection<BurialPreference>();
                await dbCtx.Preferences.AddAsync(preference);
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task<IList<Models.Preference.Preference>> GetPreference()
        {
            await using (dbCtx = new DataBaseContext())
            {
                return await dbCtx.Preferences
                    .Include(p => p.Description)
                    .ToListAsync();
            }
        }

        public async Task EditPreference(Models.Preference.Preference preference)
        {
            await using (dbCtx = new DataBaseContext())
            {
                dbCtx.Preferences.Update(preference);
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task DeletePreference(int preferenceId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Preference.Preference preference = await dbCtx.Preferences
                    .Include(p => p.Description)
                    .Include(p => p.BurialPreferences)
                    .FirstAsync(p => p.Id == preferenceId);
                dbCtx.Preferences.Remove(preference);
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task<Models.Preference.Preference> GetPreferenceById(int preferenceId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                return await dbCtx.Preferences
                    .Include(p => p.Description)
                    .FirstAsync(p => p.Id == preferenceId);
            }
        }

        public async Task<Models.Preference.Preference> GetPreferenceByBurialId(int burialId)
        {
            throw new System.NotImplementedException();
        }
    }
}
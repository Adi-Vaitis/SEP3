using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tier3.DataAccess;
using Tier3.Models;

namespace Tier3.Repositories.Burial
{
    public class BurialRepo : IBurialRepo
    {
        private DataBaseContext dbsCtx;
        
        public async Task CreateBurial(Models.Burial.Burial burial)
        {
            await using (dbsCtx = new DataBaseContext())
            {
                Models.Client.Client client = await dbsCtx.Clients
                    .Include(cl => cl.Burials)
                    .FirstAsync(c => c.Id == burial.ClientId);
                burial.ClientId = client.Id;
                if (client.Burials == null)
                {
                    client.Burials = new List<Models.Burial.Burial>();
                }

                burial.Client = new Models.Client.Client();
                burial.Date = new DateTime();
                burial.BurialPreferences = new List<BurialPreference>();
                client.Burials.Add(burial);
                dbsCtx.Clients.Update(client);
                await dbsCtx.Burial.AddAsync(burial);
                await dbsCtx.SaveChangesAsync();
            }

        }

        public async Task EditBurial(Models.Burial.Burial burial)
        {
            await using (dbsCtx = new DataBaseContext())
            {
                dbsCtx.Burial.Update(burial);
                await dbsCtx.SaveChangesAsync();
            }
        }

        public async Task DeleteBurial(int burialId)
        {
            await using (dbsCtx = new DataBaseContext())
            {
                Models.Burial.Burial burial = await dbsCtx.Burial
                    .Include(b => b.Client)
                    .Include(b1 => b1.BurialPreferences)
                    .Include(b2 => b2.Comments)
                    .Include(b3 => b3.Date)
                    .Include(b4 => b4.Location)
                    .Include(b5 => b5.NumberOfParticipants)
                    .Include(b6 => b6.FullNameOfTheDeadMan)
                    .FirstAsync(bur => bur.Id == burialId);
                burial.Client = new Models.Client.Client();
                burial.BurialPreferences = new Collection<BurialPreference>();
                burial.Date = new DateTime();
                dbsCtx.Burial.Remove(burial);
                await dbsCtx.SaveChangesAsync();
            }
        }

        public async Task<Models.Burial.Burial> GetBurial(int burialId)
        {
            await using (dbsCtx = new DataBaseContext())
            {
                return await dbsCtx.Burial
                    .Include(burial => burial.Client)
                    .FirstAsync(b => b.Id == burialId);
            }
        }

        public async Task<IList<Models.Preference.Preference>> GetPreferencesForBurial(int burialId)
        {
            await using (dbsCtx = new DataBaseContext())
            {
                Models.Burial.Burial burial = dbsCtx.Burial
                    .Include(bu => bu.BurialPreferences)
                    .First(b => b.Id == burialId);
                IList<Models.Preference.Preference> preferenceList = new List<Models.Preference.Preference>();
                foreach (var preference in burial.PreferenceForBurial)
                {
                    preferenceList.Add(preference);
                    Console.WriteLine(preference.ToString());
                }

                return preferenceList;
            }
        }

        public async Task<IList<Models.Burial.Burial>> GetBurialsForClient(int clientId)
        {
            await using (dbsCtx = new DataBaseContext())
            {
                Models.Client.Client client = dbsCtx.Clients
                    .Include(c => c.Burials)
                    .First(c => c.Id == clientId);
                IList<Models.Burial.Burial> burialList = new List<Models.Burial.Burial>();
                foreach (var variable in client.Burials)
                {
                    burialList.Add(variable);
                    Console.WriteLine(variable.ToString());
                }

                return burialList;
            }
        }
    }
}
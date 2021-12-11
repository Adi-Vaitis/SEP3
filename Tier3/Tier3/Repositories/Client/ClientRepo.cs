using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tier3.DataAccess;
using Tier3.Models;

namespace Tier3.Repositories.Client
{
    public class ClientRepo : IClientRepo
    {
        private DataBaseContext dbCtx;
        
        public async Task<string> CreateClientAccount(Models.Client.Client client)
        {
            await using (dbCtx = new DataBaseContext())
            {
                foreach (var variable in dbCtx.Clients)
                {
                    if (variable.Username.Equals(client.Username))
                    {
                        Console.WriteLine("Account already exists");
                        return "Account already exists";
                    }
                }

                client.Burials = new List<Models.Burial.Burial>();
                client.ClientBurials = new List<ClientBurial>();
                await dbCtx.Clients.AddAsync(client);
                Console.WriteLine("Account created");
                await dbCtx.SaveChangesAsync();
            }
            return "Account created";
        }

        public async Task<Models.Client.Client> GetClient(string username, string password)
        {
            try
            {
                await using (dbCtx = new DataBaseContext())
                {
                    return dbCtx.Clients
                        .First(c => c.Username.Equals(username) && c.Password.Equals(password));
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Client doesn't exist");
                throw new Exception("Account with username " + username + " not found");
            }
        }

        public async Task DeleteClient(int clientId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Client.Client client = await dbCtx.Clients
                    .Include(c => c.Burials)
                    .ThenInclude(c => c.BurialPreferences)
                    .Include(c => c.Email)
                    .Include(c => c.Name)
                    .Include(c => c.Username)
                    .Include(c => c.Password)
                    .FirstAsync(cl => cl.Id == clientId);

                client.Burials = new Collection<Models.Burial.Burial>();
                dbCtx.Clients.Remove(client);
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task<Models.Client.Client> GetClientByUsername(string username)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Client.Client client;
                
                try
                {
                    client = await dbCtx.Clients
                        .Include(cl => cl.Burials)
                        .FirstAsync(c => c.Username.Equals(username));
                }
                catch (Exception e)
                {
                    throw new Exception("Not found, check credentials");
                }

                return client;
            }
        }

        public async Task<Models.Client.Client> GetClientById(int clientId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Client.Client client;

                try
                {
                    client = await dbCtx.Clients
                        .Include(cl => cl.Burials)
                        .ThenInclude(c => c.BurialPreferences)
                        .FirstAsync(cl => cl.Id == clientId);
                }
                catch (Exception e)
                {
                    throw new Exception("Not found, check credentials");
                }

                return client;
            }
        }

        public async Task<IList<Models.Client.Client>> GetBurialsClient(int clientId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                IList<Models.Client.Client> clientList = new List<Models.Client.Client>();
                foreach (var variable in dbCtx.ClientBurials)
                {
                    if (variable.ClientId == clientId)
                    {
                        Models.Client.Client burialForClient = await dbCtx.Clients
                            .FirstAsync(c => c.Id == variable.ClientId);
                        clientList.Add(burialForClient);
                    }
                }

                return clientList;
            }
        }

        public async Task AddPreferenceToBurial(int burialId, int preferenceId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Burial.Burial burial = await dbCtx.Burial.FirstAsync(b => b.Id == burialId);
                Models.Preference.Preference preference = await dbCtx.Preferences
                    .Include(p => p.Description)
                    .FirstAsync(p => p.Id == preferenceId);

                BurialPreference burialPreference = new BurialPreference
                {
                    Burial = burial,
                    BurialId = burialId,
                    Preference = preference,
                    PreferenceId = preferenceId
                };
                if (burial.BurialPreferences == null)
                {
                    burial.BurialPreferences = new List<BurialPreference>();
                    burial.BurialPreferences.Add(burialPreference);
                    Console.WriteLine("added because it was null");
                }
                else
                {
                    burial.BurialPreferences.Add(burialPreference);
                    Console.WriteLine("added an existing one");
                }

                foreach (var variable in burial.BurialPreferences)
                {
                    Console.WriteLine("burialId= " + variable.BurialId + "\n Burial= " + variable.Burial + "preferenceId= " + variable.PreferenceId + "\n Preference= " + variable.Preference);
                }

                dbCtx.Update(burial);
                await dbCtx.SaveChangesAsync();
            }
        }

        public async Task DeletePreferenceFromBurial(int burialId, int preferenceId)
        {
            await using (dbCtx = new DataBaseContext())
            {
                BurialPreference burialPreference = dbCtx.Burial
                    .Where(b => b.Id == burialId)
                    .SelectMany(buri => buri.BurialPreferences)
                    .First(buri => buri.Preference.Id == preferenceId);
                dbCtx.Remove(burialPreference);
                Console.WriteLine("preference deleted");
                await dbCtx.SaveChangesAsync();
            }
        }
    }
}
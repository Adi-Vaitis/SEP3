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
                    if (variable.Id == client.Id)
                    {
                        Console.WriteLine("Account already exists");
                        return "Account already exists";
                    }
                }

                client.Burials = new List<Models.Burial.Burial>();
                client.ClientBurials = new List<ClientBurial>();
                client.ClientPreferences = new List<ClientPreference>();
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
                Console.WriteLine("Client doesn't exist");
            }

            return null;
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

        public async Task<string> EditClientAccount(Models.Client.Client client)
        {
            await using (dbCtx = new DataBaseContext())
            {
                Models.Client.Client client1 = await dbCtx.Clients
                    .Include(c => c.Burials)
                    .FirstAsync(cc => cc.Id == client.Id);
                client1.Username = client.Username;
                client1.Password = client.Password;
                client1.Name = client.Name;
                client1.Email = client.Email;

                dbCtx.Clients.Update(client1);
                await dbCtx.SaveChangesAsync();
            }

            return "Client updated";
        }

        public Task<Models.Client.Client> GetClientByUsername(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<Models.Client.Client> GetClientById(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Models.Client.Client>> GetBurialsClient(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task AddPreferenceToBurial(int burialId, int preferenceId)
        {
            throw new System.NotImplementedException();
        }

        public Task DeletePreferenceFromBurial(int burialId, int preferenceId)
        {
            throw new System.NotImplementedException();
        }
    }
}
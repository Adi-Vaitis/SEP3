using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tier_1.Models.Client;

namespace Tier_1.Data.ClientService
{
    public class ClientService : IClientService
    {
        public Task<string> CreateClientAccount(Client client)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> GetClient(string username, string password)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Client> ValidateClient(Client client)
        {
            HttpClient httpClient = new HttpClient();
            string clientSerialized = JsonSerializer.Serialize(client);
            
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/login"),
                Content = new StringContent(clientSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<Client>(s);
        }

        public Task DeleteClient(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> EditClientAccount(Client client)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> GetClientByUsername(string username)
        {
            throw new System.NotImplementedException();
        }

        public Task<Client> GetClientById(int clientId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IList<Client>> GetBurialsClient(int clientId)
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
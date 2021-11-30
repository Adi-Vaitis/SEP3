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
        public async Task<string> CreateClientAccount(Client client)
        {
            HttpClient httpClient = new HttpClient();
            string clientSerialized = JsonSerializer.Serialize(client);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/register"),
                Content = new StringContent(clientSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            return s;
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

        public async Task DeleteClient(int clientId)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage responseMessage = await httpClient.DeleteAsync("http://localhost:8080/delete/" + clientId);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task<string> EditClientAccount(Client client)
        {
            HttpClient httpClient = new HttpClient();
            string clientSerialized = JsonSerializer.Serialize(client);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://localhost:8080/update"),
                Content = new StringContent(clientSerialized, Encoding.UTF8, "application/json")
            };

            var response = httpClient.SendAsync(request).ConfigureAwait(false);
            var responseInfo = response.GetAwaiter().GetResult();
            string s = await responseInfo.Content.ReadAsStringAsync();
            return s;
        }

        public async Task<Client> GetClientByUsername(string username)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts?Username=" + username;
            string message = await httpClient.GetStringAsync(uri);

            Client result = JsonSerializer.Deserialize<Client>(message);
            return result;
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
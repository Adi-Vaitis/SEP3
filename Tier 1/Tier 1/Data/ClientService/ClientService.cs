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
            Console.WriteLine("REGISTEEEEER!!!!!!!!!!!!!!!");
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

        public async Task<Client> GetClientByUsername(string username)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts?Username=" + username;
            string message = await httpClient.GetStringAsync(uri);

            Client result = JsonSerializer.Deserialize<Client>(message);
            return result;
        }

        public async Task<Client> GetClientById(int clientId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/accounts/" + clientId;
            string message = await httpClient.GetStringAsync(uri);
            Client result = JsonSerializer.Deserialize<Client>(message);
            return result;
        }

        public async Task<IList<Client>> GetBurialsClient(int clientId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/burialsForTheClient/" + clientId;
            string message = await httpClient.GetStringAsync(uri);

            Console.WriteLine(message);
            
            IList<Client> result = JsonSerializer.Deserialize<IList<Client>>(message);
            return result;
        }

        public async Task AddPreferenceToBurial(int burialId, int preferenceId)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(
                String.Concat(preferenceId),
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:8080/addPreference/" + burialId, content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task DeletePreferenceFromBurial(int burialId, int preferenceId)
        {
            HttpClient httpClient = new HttpClient();
            StringContent content = new StringContent(
                String.Concat(preferenceId),
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:8080/deletePreference/" + burialId, content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}
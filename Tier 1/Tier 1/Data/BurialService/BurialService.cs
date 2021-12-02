using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tier_1.Models.Burial;

namespace Tier_1.Data.BurialService
{
    public class BurialService : IBurialService
    {
        public async Task<IList<Burial>> GetBurialsAsync(int clientId)
        {
            HttpClient httpClient = new HttpClient();
            string uri = "https://localhost:8080/burials?ClientId=" + $"{clientId}";
            string message = await httpClient.GetStringAsync(uri);
            IList<Burial> result = JsonSerializer.Deserialize<IList<Burial>>(message);
            return result;
        }

        public async Task CreateBurial(Burial burial)
        {
            HttpClient httpClient = new HttpClient();
            string burialSerialized = JsonSerializer.Serialize(burial);
            StringContent content = new StringContent(
                burialSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PostAsync("https://localhost:8080/burials", content);
        }

        public async Task EditBurial(Burial burial)
        {
            HttpClient httpClient = new HttpClient();
            string burialSerialized = JsonSerializer.Serialize(burial);
            StringContent content = new StringContent(
                burialSerialized,
                Encoding.UTF8,
                "application/json"
            );
            HttpResponseMessage responseMessage = await httpClient.PatchAsync("https://localhost:8080/burials", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }

        public async Task DeleteBurial(int burialId)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage responseMessage = await client.DeleteAsync("https://localhost:8080/burials/" + burialId);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}
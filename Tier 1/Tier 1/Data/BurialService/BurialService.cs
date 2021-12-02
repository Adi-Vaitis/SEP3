using System.Collections.Generic;
using System.Net.Http;
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

        public Task CreateBurial(Burial burial)
        {
            throw new System.NotImplementedException();
        }

        public Task EditBurial(Burial burial)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteBurial(int burialId)
        {
            throw new System.NotImplementedException();
        }
    }
}
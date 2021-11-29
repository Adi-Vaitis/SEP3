using System.Collections.Generic;
using System.Threading.Tasks;
using Tier_1.Models.Client;

namespace Tier_1.Data.ClientService
{
    public interface IClientService
    {
        Task<string> CreateClientAccount(Models.Client.Client client);
        Task<Models.Client.Client> GetClient(string username, string password);
        Task<Client> ValidateClient(Client client);
        Task DeleteClient(int clientId);
        Task<string> EditClientAccount(Models.Client.Client client);
        Task<Models.Client.Client> GetClientByUsername(string username);
        Task<Models.Client.Client> GetClientById(int clientId);
        Task<IList<Models.Client.Client>> GetBurialsClient(int clientId);
        Task AddPreferenceToBurial(int burialId, int preferenceId);
        Task DeletePreferenceFromBurial(int burialId, int preferenceId);
    }
}
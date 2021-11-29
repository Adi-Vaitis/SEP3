using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Tier3.Repositories.Client;

namespace Tier3.Networking.Client
{
    public class ServerClientHandler
    {
        private Models.Client.Client client;
        private IClientRepo clientRepo;

        public ServerClientHandler()
        {
            client = new Models.Client.Client();
            clientRepo = new ClientRepo();
        }

        public async void GetClient(NetworkStream stream, string content)
        {
            Models.Client.Client test = JsonSerializer.Deserialize<Models.Client.Client>(content);
            string username = test.Username;
            string password = test.Password;
            client = await clientRepo.GetClient(username, password);
            string reply = JsonSerializer.Serialize(client);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }
    }
}
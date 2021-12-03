using System;
using System.Threading.Tasks;
using Tier3.DataAccess;
using Tier3.Models.Client;
using Tier3.Networking.Communication;
using Tier3.Repositories.Client;

namespace Tier3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using (DataBaseContext dataBaseContext = new DataBaseContext())
            {
                DummyData(dataBaseContext);
            }
            
            SocketServer socketServer = new SocketServer();
            socketServer.StartServer();
        }

        private static void DummyData(DataBaseContext dataBaseContext)
        {
            ClientRepo clientRepo = new ClientRepo();
            Client client = new Client()
            {
                Burials = null,
                ClientBurials = null,
                ClientPreferences = null,
                Email = "client@yahoo.com",
                Name = "Marius Babanu",
                Password = "123456",
                Username = "tzanca"
            };
            //await clientRepo.CreateClientAccount(client);
            dataBaseContext.Add(client);

            dataBaseContext.SaveChanges();
        }
    }
}
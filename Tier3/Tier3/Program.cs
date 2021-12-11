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
        public async static Task Main(string[] args)
        {
            //using (DataBaseContext dataBaseContext = new DataBaseContext())
            // {
           //     DummyData(dataBaseContext);
           // }

           await Populate();
            SocketServer socketServer = new SocketServer();
            socketServer.StartServer();
        }

    /*  private static void DummyData(DataBaseContext dataBaseContext)
        {
            ClientRepo clientRepo = new ClientRepo();
            Client client = new Client()
            {
                Id=2,
                Username = "admin",
                Name = "Admin",
                Password = "admin",
                Email = "admin.com",
                Burials = null
            };
            //await clientRepo.CreateClientAccount(client);
            dataBaseContext.Add(client);

            dataBaseContext.SaveChanges();
        }
        */

    static async Task Populate()
    {
        ClientRepo clientRepo = new ClientRepo();
        Client moderator = new Client()
        {
            Username = "moderator",
            Password = "123456",
            Name = "sefu"
        };
        await clientRepo.CreateClientAccount(moderator);
        
    }
    }
}
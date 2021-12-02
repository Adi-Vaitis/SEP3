using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Tier3.Repositories.Burial;
using Tier3.Repositories.Preference;

namespace Tier3.Networking.Burial
{
    public class ServerBurialHandler
    {
        private IList<Models.Burial.Burial> burials;
        private IBurialRepo burialRepo;
        private PreferenceRepo preferenceRepo;

        public ServerBurialHandler()
        {
            burials = new List<Models.Burial.Burial>();
            burialRepo = new BurialRepo();
            preferenceRepo = new PreferenceRepo();
        }

        public async void GetBurials(NetworkStream stream, string content)
        {
            burials = await burialRepo.GetBurialsForClient(Int32.Parse(content));
            for (int i = 0; i < burials.Count; i++)
            {
                burials[i].PreferenceForBurial = await preferenceRepo.GetPreferenceByBurialId(burials[i].Id);
            }

            string reply = JsonSerializer.Serialize(burials);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }
    }
}
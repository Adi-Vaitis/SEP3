using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using Tier3.Repositories.Preference;

namespace Tier3.Networking.Preference
{
    public class ServerPreferenceHandler
    {
        private IList<Models.Preference.Preference> preferences;
        private IPreferenceRepo preferenceRepo;

        public ServerPreferenceHandler()
        {
            preferences = new List<Models.Preference.Preference>();
            preferenceRepo = new PreferenceRepo();
        }

        public async void GetPreferences(NetworkStream stream)
        {
            preferences = await preferenceRepo.GetPreference();
            string reply = JsonSerializer.Serialize(preferences);
            byte[] bytesWrite = Encoding.ASCII.GetBytes(reply);
            stream.Write(bytesWrite, 0, bytesWrite.Length);
        }
        
        
    }
}
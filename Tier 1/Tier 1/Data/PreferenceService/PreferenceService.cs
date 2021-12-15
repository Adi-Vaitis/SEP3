using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tier_1.Models.Preference;

namespace Tier_1.Data.PreferenceService
{
    public class PreferenceService : IPreferenceService
    {
        public async Task<IList<Preference>> GetPreferencesAsync()
        {
            HttpClient httpClient = new HttpClient();
            string uri = "http://localhost:8080/preferences"; 
            string message = await httpClient.GetStringAsync(uri);

            Console.WriteLine(message);
            
            IList<Preference> result = JsonSerializer.Deserialize<IList<Preference>>(message) ;
            return result;
        }

        public async Task AddPreference(Preference preference)
        {
            HttpClient httpClient = new HttpClient();
            string preferenceSerialized = JsonSerializer.Serialize(preference);
            StringContent content = new StringContent(
                preferenceSerialized,
                Encoding.UTF8,
                "application/json"
            );

            HttpResponseMessage responseMessage =
                await httpClient.PostAsync("http://localhost:8080/preferences", content);
            Console.WriteLine(responseMessage.StatusCode.ToString());
        }
    }
}
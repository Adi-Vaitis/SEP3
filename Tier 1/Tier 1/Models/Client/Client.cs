using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier_1.Models.Client
{
    public class Client
    {
        [JsonPropertyName("id")]
        [Required]
        public int Id { get; set; }
        [JsonPropertyName("username"), Required]
        public string Username { get; set; }
        [JsonPropertyName("name"), Required]
        public string Name { get; set; }
        [JsonPropertyName("password"), Required]
        public string Password { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        
        [JsonPropertyName("burials")]
        public IList<Burial.Burial> Burials { get; set; }

        public Client(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Client(string username, string name, string password)
        {
            Username = username;
            Name = name;
            Password = password;
        }

        public Client(int id, string username, string name, string password)
        {
            Id = id;
            Username = username;
            Name = name;
            Password = password;
        }

        public Client()
        {
        }
    }
}
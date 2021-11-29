using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier_1.Models.Employee
{
    public class Employee
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("username"), Required]
        public string Username { get; set; }
        [JsonPropertyName("password"), Required]
        public string Password { get; set; }

        public Employee(int id, string username, string password)
        {
            Id = id;
            Username = username;
            Password = password;
        }

        public Employee(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Employee()
        {
        }
    }
}
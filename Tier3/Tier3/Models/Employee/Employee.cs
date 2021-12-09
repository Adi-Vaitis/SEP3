using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Tier3.Models.Employee
{
    public class Employee
    {
        [Key]
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("username"), Required]
        public string Username { get; set; }
        [JsonPropertyName("password"), Required]
        public string Password { get; set; }
        
        [JsonIgnore]
        public IList<EmployeeBurial> EmployeeBurials { get; set; }
    }
}
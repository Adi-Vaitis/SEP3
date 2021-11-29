using Microsoft.EntityFrameworkCore;
using Tier3.Models;
using Tier3.Models.Burial;
using Tier3.Models.Client;
using Tier3.Models.Employee;
using Tier3.Models.Preference;

namespace Tier3.DataAccess
{
    public class DataBaseContext
    {
        
        public DbSet<Burial> Burial { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<BurialPreference> BurialPreferences { get; set; }
        public DbSet<ClientBurial> ClientBurials { get; set; }
        public DbSet<ClientPreference> ClientPreferences { get; set; }
        
        
        
    }
}
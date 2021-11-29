using Microsoft.EntityFrameworkCore;
using Tier3.Models;
using Tier3.Models.Burial;
using Tier3.Models.Client;
using Tier3.Models.Employee;
using Tier3.Models.Preference;

namespace Tier3.DataAccess
{
    public class DataBaseContext : DbContext
    {

        public DbSet<Burial> Burial { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<BurialPreference> BurialPreferences { get; set; }
        public DbSet<ClientBurial> ClientBurials { get; set; }
        public DbSet<ClientPreference> ClientPreferences { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source = C:\Users\vaiti\Documents\GitHub\SEP3\Tier3\Tier3\Tier3.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientBurial>()
                .HasKey(cb => new
                {
                    cb.ClientId,
                    cb.BurialId
                });

            modelBuilder.Entity<ClientBurial>()
                .HasOne(cb => cb.Client)
                .WithMany(cb => cb.ClientBurials)
                .HasForeignKey(cb => cb.ClientId);

            modelBuilder.Entity<ClientBurial>()
                .HasOne(cb => cb.BurialClient)
                .WithMany(cb => cb.ClientBurials)
                .HasForeignKey(cb => cb.BurialId);

            modelBuilder.Entity<Burial>()
                .HasOne<Client>(b => b.Client)
                .WithMany(b => b.Burials)
                .HasForeignKey(b => b.ClientId);

            modelBuilder.Entity<BurialPreference>()
                .HasKey(bp => new
                {
                    bp.BurialId,
                    bp.PreferenceId
                });

            modelBuilder.Entity<BurialPreference>()
                .HasOne(bp => bp.Burial)
                .WithMany(bp => bp.BurialPreferences)
                .HasForeignKey(bp => bp.BurialId);

            modelBuilder.Entity<BurialPreference>()
                .HasOne(bp => bp.Preference)
                .WithMany(bp => bp.BurialPreferences)
                .HasForeignKey(bp => bp.PreferenceId);

            modelBuilder.Entity<ClientPreference>()
                .HasKey(cp => new
                {
                    cp.ClientId,
                    cp.PreferenceId
                });

            modelBuilder.Entity<ClientPreference>()
                .HasOne(cp => cp.Client)
                .WithMany(cp => cp.ClientPreferences)
                .HasForeignKey(cp => cp.ClientId);

            modelBuilder.Entity<ClientPreference>()
                .HasOne(cp => cp.PreferenceClient)
                .WithMany(cp => cp.ClientPreferences)
                .HasForeignKey(cp => cp.PreferenceId);

        }
    }
}
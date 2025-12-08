using FCGProj.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FCGProj.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<ClientAddress> ClientAddress { get; set; }
        public DbSet<AccessProfile> AccessProfile { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasKey(c => c.IdClient);
            modelBuilder.Entity<Game>().HasKey(g => g.IdGames);
            modelBuilder.Entity<ClientAddress>().HasKey(ca => ca.IdClientAddress);
            modelBuilder.Entity<AccessProfile>().HasKey(ca => ca.IdAccessProfile);

            base.OnModelCreating(modelBuilder);
        }
    }
}

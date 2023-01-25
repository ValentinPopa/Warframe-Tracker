using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess
{
    public class DBContext : DbContext
    {
        public string connectionString = @"Server=DESKTOP-67ILI5N;Database=warframes;Trusted_Connection=True;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        public DbSet<Warframe> Warframe { get; set; }
        public DbSet<PrimaryWeapon> PrimaryWeapon { get; set; }
        public DbSet<SecondaryWeapon> SecondaryWeapon { get; set; }
        public DbSet<MeleeWeapon> MeleeWeapon { get; set; }
        public DbSet<WarframePart> WarframePart { get; set; }
        public DbSet<Relic> Relic { get; set; }
    }
}

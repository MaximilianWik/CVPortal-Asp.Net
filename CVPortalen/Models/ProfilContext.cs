using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CVPortalen.Models
{
    public class ProfilContext : IdentityDbContext<Anvandare>
    {
        public ProfilContext(DbContextOptions<ProfilContext> options) : base(options) { }

        public DbSet<Profil> Profils { get; set; }

        public DbSet<CV> cVs { get; set; }

        public DbSet<Anvandare> Anv { get; set; } 

        public DbSet<Projekt> projekt { get; set; }

        public DbSet<Meddelande> meddelande { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Anvandare>().HasData(
                new Anvandare
                {
                    Id = "eeafdb89-38a4-4e6f-a3de-63b1491c0b86", // Replace with an actual user ID
                    UserName = "filipnyden",
                    NormalizedUserName = "FILIPNYDEN",
                    Email = null,
                    NormalizedEmail = null,
                    EmailConfirmed = false,
                    PasswordHash = new PasswordHasher<Anvandare>().HashPassword(null, "Hej123!"),
                    SecurityStamp = "ZHC7O3BJZA6YHMG7J4LWDL7NW4VPWY3D", // Replace with an actual security stamp
                    ConcurrencyStamp = Guid.NewGuid().ToString(),
                    PhoneNumber = null,
                    PhoneNumberConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnd = null,
                    LockoutEnabled = true,
                    AccessFailedCount = 0
                },

                 new Anvandare
                 {
                     Id = "b3d78f9f-df9a-43e9-8a50-e1cca4bfb5d9", // Replace with an actual user ID
                     UserName = "AntonLind",
                     NormalizedUserName = "ANTONLIND",
                     Email = null,
                     NormalizedEmail = null,
                     EmailConfirmed = false,
                     PasswordHash = new PasswordHasher<Anvandare>().HashPassword(null, "Bajs123!"),
                     SecurityStamp = "3KSCKA2ZWKSZLFTU6VTN2U47BE2WEQRN", // Replace with an actual security stamp
                     ConcurrencyStamp = Guid.NewGuid().ToString(),
                     PhoneNumber = null,
                     PhoneNumberConfirmed = false,
                     TwoFactorEnabled = false,
                     LockoutEnd = null,
                     LockoutEnabled = true,
                     AccessFailedCount = 0
                 }
                 );  

            modelBuilder.Entity<CV>().HasData(
                new CV
                {
                    CVId = 1,
                    Titel = "Test1",
                    Arbetsplats = "TestCO",
                    Beskrivning = "Hej"

                },

                new CV
                {
                    CVId = 2,
                    Titel = "Test2",
                    Arbetsplats = "TestCO",
                    Beskrivning = "Hej"

                }
                );
        }
    }

}



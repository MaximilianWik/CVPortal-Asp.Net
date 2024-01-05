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


        public DbSet<Message> Messages { get; set; }

        //Meooowowwww

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
                 },


            new Anvandare
            {
                Id = "95140368-5cbe-46a2-8ff0-f573534cb391", // Replace with an actual user ID
                UserName = "JohanS",
                NormalizedUserName = "JOHANS",
                Email = null,
                NormalizedEmail = null,
                EmailConfirmed = false,
                PasswordHash = new PasswordHasher<Anvandare>().HashPassword(null, "Jon123!"),
                SecurityStamp = "2QB3XVNXYN3E3JKGLPF37UNUDS57MJC2", // Replace with an actual security stamp
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
                Id = "2a3691cd-2dcf-4850-a5f0-43f653fecc1a", // Replace with an actual user ID
                UserName = "JacobW",
                NormalizedUserName = "JACOBW",
                Email = null,
                NormalizedEmail = null,
                EmailConfirmed = false,
                PasswordHash = new PasswordHasher<Anvandare>().HashPassword(null, "Jac123!"),
                SecurityStamp = "S4LN2MR2XLOF2MAH2DALTCBZ6UMVJV22", // Replace with an actual security stamp
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
                Id = "25d150cf-9187-4a8b-9fba-301c1972ddee", // Replace with an actual user ID
                UserName = "MaxWik",
                NormalizedUserName = "MAXWIK",
                Email = null,
                NormalizedEmail = null,
                EmailConfirmed = false,
                PasswordHash = new PasswordHasher<Anvandare>().HashPassword(null, "Max123!"),
                SecurityStamp = "WHIMEAWPQ44OOY5IIDFFD4444W3VLH3G", // Replace with an actual security stamp
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PhoneNumber = null,
                PhoneNumberConfirmed = false,
                TwoFactorEnabled = false,
                LockoutEnd = null,
                LockoutEnabled = true,
                AccessFailedCount = 0
            }

            );



            // Configure the relationship between Anvandare and Message
            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany()
                .HasForeignKey(m => m.ReceiverId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Anvandare>()
                .HasOne(a => a.CV)
                .WithOne(cv => cv.User)
                .HasForeignKey<CV>(cv => cv.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Anvandare>()
                .HasMany(a => a.projekt)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Restrict);

           












        }
    }

}



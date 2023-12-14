using Microsoft.EntityFrameworkCore;

namespace CVPortalen.Models
{
    public class ProfilContext : DbContext
    {
        public ProfilContext(DbContextOptions<ProfilContext> options) : base(options) { }

        public DbSet<Profil> Profils { get; set; }

        public DbSet<CV> cVs { get; set; }

        public DbSet<Projekt> projekt { get; set; }

        public DbSet<Meddelande> meddelande { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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


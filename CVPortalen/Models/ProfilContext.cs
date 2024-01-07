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

        public DbSet<Message> Messages { get; set; }

        //Meooowowwww

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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


            modelBuilder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .HasForeignKey(m => m.SenderId)
                .HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Message>()
                .HasOne(m => m.Receiver)
                .WithMany(u => u.RecivedMessages)
                .HasForeignKey(m => m.ReceiverId)
                .HasPrincipalKey(u => u.Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }

}



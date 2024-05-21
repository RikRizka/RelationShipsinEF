using Microsoft.EntityFrameworkCore;
using OneToManyDemo.Models;
using OneToManyDemo.Models.ViewModels;
using OneToManyDemoMVC.Models.ViewModels;

namespace OneToManyDemo.Data
{
    public class BoekenDbContext : DbContext
    {
        public BoekenDbContext(DbContextOptions<BoekenDbContext> options) : base(options) { }
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Boek> Boeks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //configure Auteur entity
            modelBuilder.Entity<Auteur>()
                .HasKey(a => a.AuteurId);
            modelBuilder.Entity<Auteur>()
                .HasMany(a => a.Boeken)
                .WithOne(b => b.Auteur)
                .HasForeignKey(b => b.AuteurId)
                .OnDelete(DeleteBehavior.NoAction);


            // configure Boek entity
            modelBuilder.Entity<Boek>()
                .HasKey(b => b.BoekId);
            modelBuilder.Entity<Boek>()
                .HasOne(b => b.Auteur)
                .WithMany(a => a.Boeken)
                .HasForeignKey(b => b.AuteurId)
                .OnDelete(DeleteBehavior.NoAction);





            SeedData.AddRecords(modelBuilder);
        }

        internal void SaveChanges(BoekenViewModel data)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges(Boek boek)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges(Auteur auteur)
        {
            throw new NotImplementedException();
        }

        internal void SaveChanges(BoekAuteurViewModel boek)
        {
            throw new NotImplementedException();
        }

        public DbSet<OneToManyDemo.Models.ViewModels.BoekenViewModel> BoekenViewModel { get; set; } = default!;
        public DbSet<OneToManyDemoMVC.Models.ViewModels.EditBoekViewModel> EditBoekViewModel { get; set; } = default!;
      
    }
}

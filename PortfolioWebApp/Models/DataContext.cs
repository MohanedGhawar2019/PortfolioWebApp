using Microsoft.EntityFrameworkCore;
using PortfolioWebApp.Models.Enteties;
using System.Linq;

namespace PortfolioWebApp.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Contact> contact { get; set; }
        public DbSet<Owner> Owner { get; set; }
        public DbSet<Photographer> photographer { get; set; }
        public DbSet<Photos> photo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contact>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Owner>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Photos>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Photographer>().Property(x => x.Id).HasDefaultValueSql("NEWID()");

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Cascade;
            }

            modelBuilder.Seed();
        }
    }
}

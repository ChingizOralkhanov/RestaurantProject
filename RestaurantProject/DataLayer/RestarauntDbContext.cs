using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.DataLayer
{
    public class RestarauntDbContext : DbContext
    {
        public RestarauntDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaraunt>().Property(r => r.Id).IsRequired();
        }
        public DbSet<Restaraunt> Restaraunts { get; set; }

    }
}

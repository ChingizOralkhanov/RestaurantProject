using Microsoft.EntityFrameworkCore;
using RestaurantProject.DataLayer.DtoModels;

namespace RestaurantProject.DataLayer
{
    public class RestarauntDbContext : DbContext
    {
        public RestarauntDbContext(DbContextOptions options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasOne(customer => customer.Table);
            modelBuilder.Entity<Table>().HasOne(table => table.Customer);
            modelBuilder.Entity<Table>().HasOne(table => table.Waiter);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Restaraunt> Restaraunts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

    }
}

using Microsoft.EntityFrameworkCore;

namespace CoreDataRepository
{
    public class SampleContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=testDatabase.db");
        }
    }
}

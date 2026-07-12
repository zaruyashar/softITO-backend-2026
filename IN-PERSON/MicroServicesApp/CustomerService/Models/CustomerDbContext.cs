using Microsoft.EntityFrameworkCore;

namespace CustomerService.Models
{
    public class CustomerDbContext : DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
    }
}

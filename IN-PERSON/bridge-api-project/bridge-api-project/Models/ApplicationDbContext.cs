using Microsoft.EntityFrameworkCore;

namespace bridge_api_project.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Developer> Developers { get; set; }
    }
}

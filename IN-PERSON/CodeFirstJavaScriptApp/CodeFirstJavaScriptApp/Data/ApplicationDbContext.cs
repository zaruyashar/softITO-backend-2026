using Microsoft.EntityFrameworkCore.Diagnostics;
using CodeFirstJavaScriptApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstJavaScriptApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

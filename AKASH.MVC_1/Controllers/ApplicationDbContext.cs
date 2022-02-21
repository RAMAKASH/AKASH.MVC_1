using Microsoft.EntityFrameworkCore;
using AKASH.MVC_1.Models;

namespace AKASH.MVC_1.Controllers
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

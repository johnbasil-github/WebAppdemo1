using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using WebApp.Sales.Models;

namespace WebApp.Sales.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Orderss> Orderss { get; set; }

    }

} 

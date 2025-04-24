using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using WebApp.Entity.Models;
using WebApp.Sales.Models;

namespace WebApp.Sales.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Customers> Customers { get; set; }

        public DbSet<Orderss> Orderss { get; set; }

        public DbSet<Student> student { get; set; }

    }

} 

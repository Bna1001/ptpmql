using Microsoft.EntityFrameworkCore;
using BTLNHOM09.Models;

namespace BTLNHOM09.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Student> Student {get; set;}
    }   
}
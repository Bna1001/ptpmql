using Microsoft.EntityFrameworkCore;
using baithuchanh2003.Models;

namespace baithuchanh2003.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;} // khai báo class student (class được tạo từ models)
        public DbSet<Employee> Employees {get; set;}
        public DbSet<Person> Persons {get; set;}
        public DbSet<Customer>Customers{get;set;}
        public DbSet<Human> Humans {get; set;} 
        public DbSet<Faculty> Faculty {get; set;}
              
    }    
        
}

// class nào muốn ánh xạ thì phải khai báo ,sau khi ta đã khai báo ,chạy 2 lệnh dotnet migration và update để ánh xạ
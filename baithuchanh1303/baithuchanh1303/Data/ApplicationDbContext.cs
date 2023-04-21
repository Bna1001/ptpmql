using baithuchanh1303.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh1303.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}

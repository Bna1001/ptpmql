using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using thuchanhcodetudong.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<thuchanhcodetudong.Models.Student> Student { get; set; } = default!;

        public DbSet<thuchanhcodetudong.Models.Employee> Employee { get; set; } = default!;
    }

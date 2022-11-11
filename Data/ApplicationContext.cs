using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenDuyenCuongBTH3.Models;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<NguyenDuyenCuongBTH3.Models.Employee> Employee { get; set; } = default!;

        public DbSet<NguyenDuyenCuongBTH3.Models.Student>? Student { get; set; }

        public DbSet<NguyenDuyenCuongBTH3.Models.Person>? Person { get; set; }
    }

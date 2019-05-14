using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppProject.Models;

namespace AppProject.Models
{
    public class AppProjectContext : DbContext
    {
        public AppProjectContext (DbContextOptions<AppProjectContext> options)
            : base(options)
        {
        }

        public DbSet<AppProject.Models.Category> Category { get; set; }

        public DbSet<AppProject.Models.Customer> Customer { get; set; }

        public DbSet<AppProject.Models.Mart> Mart { get; set; }

        public DbSet<AppProject.Models.Product> Product { get; set; }

        public DbSet<AppProject.Models.SubCategory> SubCategory { get; set; }

        public DbSet<AppProject.Models.Color> Color { get; set; }

        public DbSet<AppProject.Models.ConectTable> ConectTable { get; set; }

        public DbSet<AppProject.Models.Size> Size { get; set; }
    }
}

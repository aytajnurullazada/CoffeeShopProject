using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Repository.Models;

namespace Repository.Data
{
    public class CafenodDbContext:DbContext
    {
        public CafenodDbContext(DbContextOptions<CafenodDbContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        
           
    }
}

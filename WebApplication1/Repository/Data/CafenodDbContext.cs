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
        public DbSet<Product> Products { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
        public DbSet<ReserveForm> ReserveForms { get; set; }
        public DbSet<ReserveTable> ReserveTables { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}

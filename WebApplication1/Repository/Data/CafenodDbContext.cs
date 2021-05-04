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
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Favorites> Favorites { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> productReviews { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<User> Users { get; set; }
        public IEnumerable<SliderItem> SliderItems { get; set; }
        public IEnumerable<object> ShopCollection { get; set; }
    }
}

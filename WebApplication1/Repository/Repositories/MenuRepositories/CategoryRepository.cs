using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly CafenodDbContext _context;

        public CategoryRepository(CafenodDbContext context)
        {
            _context = context;
        }

        public Category CreateCategory(Category category)
        {
            category.AddedDate = DateTime.Now;
            _context.Categories.Add(category);
            _context.SaveChanges();
            return category;
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }

        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories.Where(d => d.Status)
                                        .ToList();
        }

        public Category GetCategoryById(int id)
        {
            return _context.Categories.Find(id);
        }

        public void UpdateCategory(Category categoryToUpdate, Category category)
        {
            categoryToUpdate.Status = category.Status;
            categoryToUpdate.Name = category.Name;
            categoryToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }
    }
}

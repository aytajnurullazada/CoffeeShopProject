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
        public IEnumerable<Category> GetCategory()
        {
            return _context.Categories.Where(d => d.Status)
                                        .ToList();
        }
        
    }
}

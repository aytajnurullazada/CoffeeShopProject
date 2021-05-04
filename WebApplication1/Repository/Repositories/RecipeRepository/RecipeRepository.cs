using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.RecipeRepository
{
   public class RecipeRepository : IRecipeRepository
    {
        private readonly CafenodDbContext _context;

        public RecipeRepository(CafenodDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Recipe> GetRecipes()
        {
            return _context.Recipes.Where(s => s.Status)
                                   .OrderBy(s => s.OrderBy)
                                   .ToList();

        }
    }
}

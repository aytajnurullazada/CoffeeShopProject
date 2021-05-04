using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.RecipeRepository
{
    public interface IRecipeRepository
    {
        IEnumerable<Recipe> GetRecipes();
    }
}

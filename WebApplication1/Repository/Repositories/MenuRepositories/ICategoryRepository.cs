using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategory();
        IEnumerable<Category> GetCategories();
        Category CreateCategory(Category category);
        Category GetCategoryById(int id);
        void UpdateCategory(Category categoryToUpdate, Category category);
        void DeleteCategory(Category category);
    }
}

using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetPopularProduct(int limit);
        IEnumerable<Product> GetProduct();

    }
}

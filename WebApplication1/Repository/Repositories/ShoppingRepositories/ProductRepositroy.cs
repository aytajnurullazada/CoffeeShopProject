using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
  public  class ProductRepositroy: IProductRepository
    {
        private readonly CafenodDbContext _context;

        public ProductRepositroy(CafenodDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetPopularProduct(int limit)
        {
            return _context.Products.Where(p => p.Status)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }

        public IEnumerable<Product> GetProduct()
        {
            throw new NotImplementedException();
        }
    }
}

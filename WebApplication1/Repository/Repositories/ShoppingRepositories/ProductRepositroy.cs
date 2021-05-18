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

        public Product CreateProduct(Product product)
        {
            product.AddedDate = DateTime.Now;
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public IEnumerable<Product> GetPopularProduct(int limit)
        {
            return _context.Products.Where(p => p.Status)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("Department")
                                     .FirstOrDefault(p => p.Status && p.Id == id);
                                    
        }

        public Product GetProductDetails(int Id)
        {
            return _context.Products
                           .FirstOrDefault(p => p.Status && p.Id == Id);
                                    
        }

        public IEnumerable<Product> GetProductForSale()
        {
            return _context.Products.Include("Department")
                                    .Where(p => p.Status)
                                    .OrderByDescending(p => p.AddedDate)
                                    .ToList();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList()
                                    .OrderByDescending(p => p.AddedDate);
        }

        public IEnumerable<Product> GetRelatedProduct(int limit)
        {
            return _context.Products.Where(p => p.Status)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }

        public void UpdateProduct(Product productToUpdate, Product product)
        {
            productToUpdate.Status = product.Status;
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Description = product.Description;
            productToUpdate.DepartmentId = product.DepartmentId;
            productToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();


        }
    }
}

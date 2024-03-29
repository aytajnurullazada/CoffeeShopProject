﻿using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetPopularProduct(int limit);
        IEnumerable<Product> GetProductForSale();
        Product GetProductDetails(int Id);
        IEnumerable<Product> GetRelatedProduct(int limit);
        IEnumerable<Product> GetProducts();
        Product CreateProduct(Product product);
        Product GetProductById(int id);
        void UpdateProduct(Product productToUpdate, Product product);
        void DeleteProduct(Product product);
    }
}

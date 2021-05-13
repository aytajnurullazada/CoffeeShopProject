using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
   public class BasketRepository: IBasketRepository
    {
        private readonly CafenodDbContext _context;

        public BasketRepository(CafenodDbContext context)
        {
            _context = context;
        }

        public void ChangeCount(Basket basketItem, int count)
        {
            basketItem.Count = count;
            _context.SaveChanges();
        }

        public Basket CreateBasket(Basket basket)
        {
            basket.AddedDate = DateTime.Now;
            basket.ModifiedDate = DateTime.Now;

            _context.Baskets.Add(basket);
            _context.SaveChanges();
            return _context.Baskets.FirstOrDefault(b => b.Status);

        }

        public Basket GetBasketById(int id)
        {
            return _context.Baskets.Find(id);
        }

        public IEnumerable<Basket> GetBasketByToken(string token)
        {
            return _context.Baskets.Include("Product")
                                   .Where(b => b.Token == token && b.Status)
                                   .ToList();
        }

        public Basket GetBasketProductAndToken(int ProductId, string token)
        {
            return _context.Baskets.SingleOrDefault(b => b.ProductId == ProductId && b.Token == token);
        }

        public void RemoveBasket(Basket basket)
        {
            _context.Baskets.Remove(basket);
            _context.SaveChanges();


        }
    }
}

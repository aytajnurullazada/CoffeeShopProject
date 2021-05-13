using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IBasketRepository
    {
        IEnumerable<Basket> GetBasketByToken(string token);
        Basket CreateBasket(Basket basket);
        Basket GetBasketById(int id);
        void RemoveBasket(Basket basket);
        Basket GetBasketProductAndToken(int ProductId, string token);
        void ChangeCount(Basket basketItem, int count);
    }
}

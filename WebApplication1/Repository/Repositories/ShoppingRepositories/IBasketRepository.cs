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
    }
}

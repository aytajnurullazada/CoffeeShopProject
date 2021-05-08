using Microsoft.AspNetCore.Mvc;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        private readonly IBasketRepository _basketRepository;
        public CartController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Remove(int id)
        {
            var basket = _basketRepository.GetBasketById(id);

            if (basket == null) return NotFound();

            Request.Cookies.TryGetValue("token", out string token);

            if (basket.Token != token) return NotFound();

            _basketRepository.RemoveBasket(basket);

            return Ok();

        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CartController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        public CartController(IMapper mapper,
                              IBasketRepository basketRepository)
        {
            _mapper = mapper;
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
            var basketItems = _basketRepository.GetBasketByToken(token);

            var basketModel = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);
            var total = 0M;
            foreach (var item in basketModel)
            {
                var price = item.Product.Price;
                total += (price * item.Count);
            }
            return Ok(new
            {
                count = basketItems.Count(),
                total = total.ToString("#.00")
            });


        }
    }
}

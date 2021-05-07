using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class HeaderBasketViewComponent: ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;
        public HeaderBasketViewComponent(IMapper mapper,
                                 IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
        }
        public IViewComponentResult Invoke()
        {
            Request.Cookies.TryGetValue("token", out string token);
            var basketItems = _basketRepository.GetBasketByToken(token);
            var model = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);
            return View(model);
        }
    }
}

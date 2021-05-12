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
    public class ShopController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ShopController(IMapper mapper,
                             IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetProductForSale();
            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(model);
        }

        public IActionResult ShopDetails()
        {

            return View();
        }
    }
}

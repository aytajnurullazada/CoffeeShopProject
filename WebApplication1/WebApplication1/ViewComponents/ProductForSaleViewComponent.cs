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
    public class ProductForSaleViewComponent: ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductForSaleViewComponent(IMapper mapper,
                                           IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public IViewComponentResult Invoke(int Id)
        {
            var products = _productRepository.GetProductForSale(Id);
            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(model);
        }
    }
}

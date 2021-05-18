using Admin.Models.Shopping;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.ShoppingRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public ProductsController(IMapper mapper,
                                     IProductRepository productRepository,
                                     IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();
            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);
            return View(model);
        }
        public IActionResult Create()
        {
            ViewBag.Departments = _departmentRepository.GetDepartments();
            return View();
        }
        [HttpPost]
        public IActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<ProductViewModel, Product>(model);
                _productRepository.CreateProduct(product);

                return RedirectToAction("index");
            }
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();
            var model = _mapper.Map<Product, ProductViewModel>(product);
            model.DepartmentId = product.DepartmentId;
            ViewBag.Departments = _departmentRepository.GetDepartments();
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<ProductViewModel, Product>(model);
                var productToUpdate = _productRepository.GetProductById(model.Id);
                if (productToUpdate == null) return NotFound();
                _productRepository.UpdateProduct(productToUpdate, product);

            }
            ViewBag.Departments = _departmentRepository.GetDepartments();
            return RedirectToAction("index");
        }
        public IActionResult Delete(int id)
        {
            Product product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();
            _productRepository.DeleteProduct(product);
            return RedirectToAction("index");
        }

    }
}

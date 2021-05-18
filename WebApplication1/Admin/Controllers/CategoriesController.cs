using Admin.Models.Menu;
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
    public class CategoriesController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(IMapper mapper,
                                     ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var categories = _categoryRepository.GetCategories();
            var model = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Category category = _mapper.Map<CategoryViewModel, Category>(model);

                _categoryRepository.CreateCategory(category);
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            if (category == null) return NotFound();
            var model = _mapper.Map<Category, CategoryViewModel>(category);
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                Category category = _mapper.Map<CategoryViewModel, Category>(model);
                Category categoryToUpdate = _categoryRepository.GetCategoryById(model.Id);
                if (categoryToUpdate == null) return NotFound();
                _categoryRepository.UpdateCategory(categoryToUpdate, category);
                return RedirectToAction("index");
            }
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            if (category == null) return NotFound();
            _categoryRepository.DeleteCategory(category);
            return RedirectToAction("index");
        }

    }
}

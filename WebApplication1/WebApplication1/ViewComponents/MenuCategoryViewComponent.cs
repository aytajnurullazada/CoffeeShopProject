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
    public class MenuCategoryViewComponent: ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public MenuCategoryViewComponent(IMapper mapper,
                                   ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetCategory();
            var model = _mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);
            return View(model);
        }
    }
}

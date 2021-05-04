using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.RecipeRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class RecipeViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IRecipeRepository _recipeRepository;

        public RecipeViewComponent(IMapper mapper,
                                   IRecipeRepository recipeRepository)
        {
            _mapper = mapper;
            _recipeRepository = recipeRepository;
        }

        public IViewComponentResult Invoke()
        {
            var recipes = _recipeRepository.GetRecipes();
            var model = _mapper.Map<IEnumerable<Recipe>, IEnumerable<RecipeViewModel>>(recipes);
            return View(model);
        }
    }
}

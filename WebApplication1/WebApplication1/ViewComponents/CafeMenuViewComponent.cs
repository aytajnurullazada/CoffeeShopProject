using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.MenuRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class CafeMenuViewComponent: ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IMenuRepository _menuRepository;

        public CafeMenuViewComponent(IMapper mapper,
                                   IMenuRepository menuRepository)
        {
            _mapper = mapper;
            _menuRepository = menuRepository;
        }

        public IViewComponentResult Invoke()
        {
            var menus = _menuRepository.GetMenus();
            var model = _mapper.Map<IEnumerable<Menu>, IEnumerable<MenuViewModel>>(menus);
            return View(model);
        }
    }
}

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
    public class MenuViewComponent :ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IDepartmentRepository _departmentRepository;
        public MenuViewComponent(IMapper mapper,
                                 IDepartmentRepository departmentRepository)
        {
            _mapper = mapper;
            _departmentRepository = departmentRepository;
        }
        public IViewComponentResult Invoke()
        {
            var departments = _departmentRepository.GetDepartmentsWithCategory();
            var model = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(model);
        }
    }
}

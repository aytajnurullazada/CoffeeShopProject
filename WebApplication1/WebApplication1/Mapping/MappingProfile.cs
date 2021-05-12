using AutoMapper;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<Department, DepartmentViewModel>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<Basket, BasketViewModel>();
            CreateMap<Menu, MenuViewModel>();
            CreateMap<Category, CategoryViewModel>();
        }
    }
}

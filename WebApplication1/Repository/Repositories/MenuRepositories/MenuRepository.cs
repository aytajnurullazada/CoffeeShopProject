using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.MenuRepositories
{
   public class MenuRepository:IMenuRepository
   {
        private readonly CafenodDbContext _context;

        public MenuRepository(CafenodDbContext context)
        {
            _context = context;
        }
        
        IEnumerable<Menu> IMenuRepository.GetMenus()
        {
            return _context.Menus.Where(s => s.Status)
                                  .OrderBy(s => s.OrderBy)
                                  .ToList();
        }
    }
}

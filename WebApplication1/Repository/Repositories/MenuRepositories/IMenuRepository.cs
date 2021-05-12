using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.MenuRepositories
{
    public interface IMenuRepository
    {
        IEnumerable<Menu> GetMenus();
    }
}

using Microsoft.EntityFrameworkCore;
using Repository.Data;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CafenodDbContext _context;

        public DepartmentRepository(CafenodDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Department> GetDepartmentsWithCategory()
        {
            return _context.Departments.Where(d => d.Status)
                                        .ToList();
        }
    }
}

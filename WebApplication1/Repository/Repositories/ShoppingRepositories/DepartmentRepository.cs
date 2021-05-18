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

        public Department CreateDepartment(Department department)
        {
            department.AddedDate = DateTime.Now;
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;

        }

        public void DeleteDepartment(Department department)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();

        }

        public Department GetDepartmentById(int id)
        {
            return _context.Departments.Find(id);
        }

        public IEnumerable<Department> GetDepartments()
        {
            return _context.Departments.ToList();
        }

        public IEnumerable<Department> GetDepartmentsWithCategory()
        {
            return _context.Departments.Where(d => d.Status)
                                        .ToList();
        }

        public void UpdateDepartment(Department departmentToUpdate, Department department)
        {
            departmentToUpdate.Status = department.Status;
            departmentToUpdate.Name = department.Name;
            departmentToUpdate.ModifiedDate = DateTime.Now;
            _context.SaveChanges();
        }
    }
}

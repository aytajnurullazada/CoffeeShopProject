using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories.ShoppingRepositories
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetDepartmentsWithCategory();
        IEnumerable<Department> GetDepartments();
        Department CreateDepartment(Department department);
        Department GetDepartmentById(int id);
        void UpdateDepartment(Department departmentToUpdate, Department department);
        void DeleteDepartment(Department department);
    }
}

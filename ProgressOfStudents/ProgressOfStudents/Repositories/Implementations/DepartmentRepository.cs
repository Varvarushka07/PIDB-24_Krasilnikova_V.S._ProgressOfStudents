using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class DepartmentRepository : IDepartmentRepository
{
    public void CreateDepartment(Department department)
    {
    }

    public void DeleteDepartment(int id)
    {
    }

    public Department ReadDepartmentById(int id)
    {
        return Department.CreateEntity(0, string.Empty, 0, string.Empty, string.Empty);
    }

    public IEnumerable<Department> ReadDepartments()
    {
        return [];
    }

    public void UpdateDepartment(Department department)
    {
    }
}
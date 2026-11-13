using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface IDepartmentRepository
{
    IEnumerable<Department> ReadDepartments();
    Department ReadDepartmentById(int id);
    void CreateDepartment(Department department);
    void UpdateDepartment(Department department);
    void DeleteDepartment(int id);
}
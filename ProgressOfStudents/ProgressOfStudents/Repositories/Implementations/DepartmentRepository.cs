using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<DepartmentRepository> _logger;

        public DepartmentRepository(DataContext context, ILogger<DepartmentRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Department> ReadDepartments()
        {
            _logger.LogInformation("Получение списка кафедр"); // Лог чтения
            _context.ChangeTracker.Clear();
            return _context.Departments.OrderBy(x => x.Id).ToList();
        }

        public Department ReadDepartmentById(int id)
        {
            return _context.Departments.FirstOrDefault(x => x.Id == id)!;
        }

        public void CreateDepartment(Department department)
        {
            _logger.LogInformation("Добавление кафедры: {name}", department.Name);
            _context.Departments.Add(department);
            _context.SaveChanges();
        }

        public void UpdateDepartment(Department department)
        {
            _logger.LogInformation("Редактирование кафедры ID: {id}", department.Id);
            var existing = _context.Departments.Find(department.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(department);
                _context.SaveChanges();
            }
        }

        public void DeleteDepartment(int id)
        {
            _logger.LogInformation("Удаление кафедры ID: {id}", id);
            var dept = _context.Departments.Find(id);
            if (dept != null)
            {
                _context.Departments.Remove(dept);
                _context.SaveChanges();
            }
        }
    }
}
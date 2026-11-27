using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<StudentRepository> _logger;

        public StudentRepository(DataContext context, ILogger<StudentRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Student> ReadStudents()
        {
            _logger.LogInformation("Получение списка студентов");
            _context.ChangeTracker.Clear();
            return _context.Students.OrderBy(x => x.Id).ToList();
        }

        public void CreateStudent(Student student)
        {
            _logger.LogInformation("Добавление студента: {name}", student.FullName);
            _context.Students.Add(student);
            _context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            _logger.LogInformation("Удаление студента ID: {id}", id);
            var student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }
    }
}
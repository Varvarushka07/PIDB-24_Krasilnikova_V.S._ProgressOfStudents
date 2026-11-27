using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class TeacherRepository : ITeacherRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<TeacherRepository> _logger;

        public TeacherRepository(DataContext context, ILogger<TeacherRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Teacher> ReadTeachers()
        {
            _logger.LogInformation("Получение списка преподавателей");
            _context.ChangeTracker.Clear();
            return _context.Teachers.OrderBy(x => x.Id).ToList();
        }

        public Teacher ReadTeacherById(int id)
        {
            return _context.Teachers.FirstOrDefault(x => x.Id == id)!;
        }

        public void CreateTeacher(Teacher teacher)
        {
            _logger.LogInformation("Добавление преподавателя: {name}", teacher.FullName);
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _logger.LogInformation("Редактирование преподавателя ID: {id}", teacher.Id);
            var existing = _context.Teachers.Find(teacher.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(teacher);
                _context.SaveChanges();
            }
        }

        public void DeleteTeacher(int id)
        {
            _logger.LogInformation("Удаление преподавателя ID: {id}", id);
            var teacher = _context.Teachers.Find(id);
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
            }
        }
    }
}
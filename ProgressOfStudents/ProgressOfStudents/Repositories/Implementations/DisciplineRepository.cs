using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class DisciplineRepository : IDisciplineRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<DisciplineRepository> _logger;

        public DisciplineRepository(DataContext context, ILogger<DisciplineRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<Discipline> ReadDisciplines()
        {
            _logger.LogInformation("Получение списка дисциплин");
            _context.ChangeTracker.Clear();
            return _context.Disciplines.OrderBy(x => x.Id).ToList();
        }

        public Discipline ReadDisciplineById(int id)
        {
            return _context.Disciplines.FirstOrDefault(x => x.Id == id)!;
        }

        public void CreateDiscipline(Discipline discipline)
        {
            _logger.LogInformation("Добавление дисциплины: {name}", discipline.Name);
            _context.Disciplines.Add(discipline);
            _context.SaveChanges();
        }

        public void UpdateDiscipline(Discipline discipline)
        {
            _logger.LogInformation("Редактирование дисциплины ID: {id}", discipline.Id);
            var existing = _context.Disciplines.Find(discipline.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(discipline);
                _context.SaveChanges();
            }
        }

        public void DeleteDiscipline(int id)
        {
            _logger.LogInformation("Удаление дисциплины ID: {id}", id);
            var disc = _context.Disciplines.Find(id);
            if (disc != null)
            {
                _context.Disciplines.Remove(disc);
                _context.SaveChanges();
            }
        }
    }
}
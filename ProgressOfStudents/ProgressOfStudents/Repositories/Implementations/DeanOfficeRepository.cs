using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class DeanOfficeRepository : IDeanOfficeRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<DeanOfficeRepository> _logger;

        public DeanOfficeRepository(DataContext context, ILogger<DeanOfficeRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<DeanOffice> ReadDeanOffices()
        {
            _logger.LogInformation("Получение списка деканатов"); // Лог чтения
            _context.ChangeTracker.Clear();
            return _context.DeanOffices.OrderBy(x => x.Id).ToList();
        }

        public DeanOffice ReadDeanOfficeById(int id)
        {
            return _context.DeanOffices.FirstOrDefault(x => x.Id == id)!;
        }

        public void CreateDeanOffice(DeanOffice deanOffice)
        {
            _logger.LogInformation("Добавление деканата: {name}", deanOffice.Name);
            _context.DeanOffices.Add(deanOffice);
            _context.SaveChanges();
        }

        public void UpdateDeanOffice(DeanOffice deanOffice)
        {
            _logger.LogInformation("Редактирование деканата ID: {id}", deanOffice.Id);
            var existing = _context.DeanOffices.Find(deanOffice.Id);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(deanOffice);
                _context.SaveChanges();
            }
        }

        public void DeleteDeanOffice(int id)
        {
            _logger.LogInformation("Удаление деканата ID: {id}", id);
            var deanOffice = _context.DeanOffices.Find(id);
            if (deanOffice != null)
            {
                _context.DeanOffices.Remove(deanOffice);
                _context.SaveChanges();
            }
        }
    }
}
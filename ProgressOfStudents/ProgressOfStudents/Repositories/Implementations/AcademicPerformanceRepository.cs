using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class AcademicPerformanceRepository : IAcademicPerformanceRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<AcademicPerformanceRepository> _logger;

        public AcademicPerformanceRepository(DataContext context, ILogger<AcademicPerformanceRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<AcademicPerformance> ReadPerformances()
        {
            _logger.LogInformation("Получение списка успеваемости");
            _context.ChangeTracker.Clear();
            return _context.AcademicPerformances.OrderBy(x => x.Id).ToList();
        }

        public void CreatePerformance(AcademicPerformance performance)
        {
            _logger.LogInformation("Добавление оценки студенту ID: {studentId}", performance.StudentId);

            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.AcademicPerformances.Add(performance);
                _context.SaveChanges();

                transaction.Commit();
                _logger.LogInformation("Оценка успешно добавлена");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                _logger.LogError(ex, "Ошибка при добавлении оценки");
                throw;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class DisciplineAssignmentRepository : IDisciplineAssignmentRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<DisciplineAssignmentRepository> _logger;

        public DisciplineAssignmentRepository(DataContext context, ILogger<DisciplineAssignmentRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<DisciplineAssignment> ReadAssignments()
        {
            _logger.LogInformation("Получение списка ведений дисциплин");
            _context.ChangeTracker.Clear();
            return _context.DisciplineAssignments.OrderBy(x => x.Id).ToList();
        }

        public void CreateAssignment(DisciplineAssignment assignment)
        {
            _logger.LogInformation("Добавление ведения дисциплины. Преподаватель ID: {teacherId}", assignment.TeacherId);
            _context.DisciplineAssignments.Add(assignment);
            _context.SaveChanges();
        }
    }
}
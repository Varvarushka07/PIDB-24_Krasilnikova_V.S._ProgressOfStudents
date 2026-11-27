using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class GroupRepository : IGroupRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<GroupRepository> _logger;

        public GroupRepository(DataContext context, ILogger<GroupRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<ProgressOfStudents.Entities.Group> ReadGroups()
        {
            _logger.LogInformation("Получение списка групп");
            _context.ChangeTracker.Clear();
            return _context.Groups.OrderBy(x => x.Id).ToList();
        }

        public void CreateGroup(ProgressOfStudents.Entities.Group group)
        {
            _logger.LogInformation("Добавление группы: {number}", group.GroupNumber);
            _context.Groups.Add(group);
            _context.SaveChanges();
        }
    }
}
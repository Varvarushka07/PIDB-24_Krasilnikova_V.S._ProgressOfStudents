using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProgressOfStudents.Data;
using ProgressOfStudents.Entities;

namespace ProgressOfStudents.Repositories.Implementations
{
    internal class StreamRepository : IStreamRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<StreamRepository> _logger;

        public StreamRepository(DataContext context, ILogger<StreamRepository> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public IEnumerable<ProgressOfStudents.Entities.Stream> ReadStreams()
        {
            _logger.LogInformation("Получение списка потоков");
            _context.ChangeTracker.Clear();
            return _context.Streams.OrderBy(x => x.Id).ToList();
        }

        public void CreateStream(ProgressOfStudents.Entities.Stream stream)
        {
            _logger.LogInformation("Добавление потока: {name}", stream.Name);
            _context.Streams.Add(stream);
            _context.SaveChanges();
        }
    }
}
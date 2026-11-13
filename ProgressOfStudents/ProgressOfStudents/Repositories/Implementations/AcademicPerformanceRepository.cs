using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class AcademicPerformanceRepository : IAcademicPerformanceRepository
{
    public void CreatePerformance(AcademicPerformance performance)
    {
    }

    public IEnumerable<AcademicPerformance> ReadPerformances()
    {
        return [];
    }
}
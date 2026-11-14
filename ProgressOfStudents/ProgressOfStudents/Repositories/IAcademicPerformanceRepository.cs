using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface IAcademicPerformanceRepository
{
    IEnumerable<AcademicPerformance> ReadPerformances();
    void CreatePerformance(AcademicPerformance performance);
}
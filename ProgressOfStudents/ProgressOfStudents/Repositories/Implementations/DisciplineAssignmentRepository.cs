using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class DisciplineAssignmentRepository : IDisciplineAssignmentRepository
{
    public void CreateAssignment(DisciplineAssignment assignment)
    {
    }

    public IEnumerable<DisciplineAssignment> ReadAssignments()
    {
        return [];
    }
}
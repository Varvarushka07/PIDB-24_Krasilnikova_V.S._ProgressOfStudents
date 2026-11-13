using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface IDisciplineAssignmentRepository
{
    IEnumerable<DisciplineAssignment> ReadAssignments();
    void CreateAssignment(DisciplineAssignment assignment);
}
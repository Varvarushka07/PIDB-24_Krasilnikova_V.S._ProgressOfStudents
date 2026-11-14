using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class DisciplineAssignment
{
    public int Id { get; private set; }
    public int TeacherId { get; private set; }
    public int DisciplineId { get; private set; }
    public int DepartmentId { get; private set; }
    public int Semester { get; private set; }
    public string AcademicYear { get; private set; } = string.Empty;

    public static DisciplineAssignment CreateEntity(int id, int teacherId, int disciplineId,
        int departmentId, int semester, string academicYear)
    {
        return new DisciplineAssignment
        {
            Id = id,
            TeacherId = teacherId,
            DisciplineId = disciplineId,
            DepartmentId = departmentId,
            Semester = semester,
            AcademicYear = academicYear ?? string.Empty
        };
    }
}
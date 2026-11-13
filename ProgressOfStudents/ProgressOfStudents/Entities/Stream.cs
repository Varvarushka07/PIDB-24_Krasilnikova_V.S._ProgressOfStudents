using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class Stream
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int EnrollmentYear { get; private set; }
    public int DepartmentId { get; private set; }

    public static Stream CreateEntity(int id, string name, int enrollmentYear, int departmentId)
    {
        return new Stream
        {
            Id = id,
            Name = name ?? string.Empty,
            EnrollmentYear = enrollmentYear,
            DepartmentId = departmentId
        };
    }
}
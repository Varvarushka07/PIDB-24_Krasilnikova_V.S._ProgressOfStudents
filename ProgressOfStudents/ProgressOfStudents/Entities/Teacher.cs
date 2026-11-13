using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class Teacher
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;

    public static Teacher CreateEntity(int id, string fullName)
    {
        return new Teacher
        {
            Id = id,
            FullName = fullName ?? string.Empty,
        };
    }
}

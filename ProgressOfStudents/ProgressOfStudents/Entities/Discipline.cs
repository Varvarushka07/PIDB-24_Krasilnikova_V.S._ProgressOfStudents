using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class Discipline
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int Hours { get; private set; }

    public static Discipline CreateEntity(int id, string name, int hours)
    {
        return new Discipline
        {
            Id = id,
            Name = name ?? string.Empty,
            Hours = hours
        };
    }
}
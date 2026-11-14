using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class DisciplineRepository : IDisciplineRepository
{
    public void CreateDiscipline(Discipline discipline)
    {
    }

    public void DeleteDiscipline(int id)
    {
    }

    public Discipline ReadDisciplineById(int id)
    {
        return Discipline.CreateEntity(0, string.Empty, 0);
    }

    public IEnumerable<Discipline> ReadDisciplines()
    {
        return [];
    }

    public void UpdateDiscipline(Discipline discipline)
    {
    }
}
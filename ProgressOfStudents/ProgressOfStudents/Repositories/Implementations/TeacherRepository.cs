using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class TeacherRepository : ITeacherRepository
{
    public void CreateTeacher(Teacher teacher)
    {
    }

    public void DeleteTeacher(int id)
    {
    }

    public Teacher ReadTeacherById(int id)
    {
        return Teacher.CreateEntity(0, string.Empty);
    }

    public IEnumerable<Teacher> ReadTeachers()
    {
        return [];
    }

    public void UpdateTeacher(Teacher teacher)
    {
    }
}
using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class StudentRepository : IStudentRepository
{
    public void CreateStudent(Student student)
    {
    }

    public void DeleteStudent(int id)
    {
    }

    public IEnumerable<Student> ReadStudents()
    {
        return [];
    }
}
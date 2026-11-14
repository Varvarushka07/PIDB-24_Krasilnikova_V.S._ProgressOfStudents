using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface IStudentRepository
{
    IEnumerable<Student> ReadStudents();
    void CreateStudent(Student student);
    void DeleteStudent(int id);
}
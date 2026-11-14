using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface ITeacherRepository
{
    IEnumerable<Teacher> ReadTeachers();
    Teacher ReadTeacherById(int id);
    void CreateTeacher(Teacher teacher);
    void UpdateTeacher(Teacher teacher);
    void DeleteTeacher(int id);
}

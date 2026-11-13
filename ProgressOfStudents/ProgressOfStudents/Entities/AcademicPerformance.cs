using ProgressOfStudents.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class AcademicPerformance
{
    public int StudentId { get; private set; }
    public int AssignmentId { get; private set; }
    public int Grade { get; private set; }
    public DateTime ExamDate { get; private set; }
    public ControlType ControlType { get; private set; }

    public static AcademicPerformance CreateOperation(int studentId,
        int assignmentId, int grade, ControlType controlType)
    {
        return new AcademicPerformance
        {
            StudentId = studentId,
            AssignmentId = assignmentId,
            Grade = grade,
            ExamDate = DateTime.Now,
            ControlType = controlType
        };
    }
}
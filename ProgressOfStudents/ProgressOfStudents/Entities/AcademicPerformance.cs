using System;
using System.ComponentModel.DataAnnotations;
using ProgressOfStudents.Entities.Enums;

namespace ProgressOfStudents.Entities
{
    public class AcademicPerformance
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public int StudentId { get; private set; }

        [Required]
        public int AssignmentId { get; private set; }

        [Required]
        [Range(2, 5)]
        public int Grade { get; private set; }

        [Required]
        public DateTime ExamDate { get; private set; }

        [Required]
        public ControlType ControlType { get; private set; }

        public AcademicPerformance() { }

        public static AcademicPerformance CreateOperation(int studentId, int assignmentId, int grade, ControlType controlType)
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
}
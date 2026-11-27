using System.ComponentModel.DataAnnotations;

namespace ProgressOfStudents.Entities
{
    public class DisciplineAssignment
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        public int TeacherId { get; private set; }

        [Required]
        public int DisciplineId { get; private set; }

        [Required]
        public int DepartmentId { get; private set; }

        [Required]
        public int Semester { get; private set; }

        [Required]
        [MaxLength(9)]
        public string AcademicYear { get; private set; } = string.Empty;

        public DisciplineAssignment() { }

        public static DisciplineAssignment CreateEntity(int id, int teacherId, int disciplineId, int departmentId, int semester, string academicYear)
        {
            return new DisciplineAssignment
            {
                Id = id,
                TeacherId = teacherId,
                DisciplineId = disciplineId,
                DepartmentId = departmentId,
                Semester = semester,
                AcademicYear = academicYear ?? string.Empty
            };
        }
    }
}
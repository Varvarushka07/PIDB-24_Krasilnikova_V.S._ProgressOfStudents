using System.ComponentModel.DataAnnotations;

namespace ProgressOfStudents.Entities
{
    public class Stream
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; private set; } = string.Empty;

        [Required]
        public int EnrollmentYear { get; private set; }

        [Required]
        public int DepartmentId { get; private set; }
        public Stream() { }

        public static Stream CreateEntity(int id, string name, int enrollmentYear, int departmentId)
        {
            return new Stream
            {
                Id = id,
                Name = name ?? string.Empty,
                EnrollmentYear = enrollmentYear,
                DepartmentId = departmentId
            };
        }
    }
}
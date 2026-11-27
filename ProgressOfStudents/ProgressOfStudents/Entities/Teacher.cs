using System.ComponentModel.DataAnnotations;

namespace ProgressOfStudents.Entities
{
    public class Teacher
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; private set; } = string.Empty;

        public Teacher() { }

        public static Teacher CreateEntity(int id, string fullName)
        {
            return new Teacher
            {
                Id = id,
                FullName = fullName ?? string.Empty
            };
        }
    }
}
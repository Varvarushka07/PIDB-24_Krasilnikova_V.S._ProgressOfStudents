using System.ComponentModel.DataAnnotations;

namespace ProgressOfStudents.Entities
{
    public class Discipline
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; private set; } = string.Empty;

        [Required]
        public int Hours { get; private set; }

        public Discipline() { }

        public static Discipline CreateEntity(int id, string name, int hours)
        {
            return new Discipline
            {
                Id = id,
                Name = name ?? string.Empty,
                Hours = hours
            };
        }
    }
}
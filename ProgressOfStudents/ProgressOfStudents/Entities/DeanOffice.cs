using System.ComponentModel.DataAnnotations;

namespace ProgressOfStudents.Entities
{
    public class DeanOffice
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; private set; } = string.Empty;

        [Required]
        public string DeanFullName { get; private set; } = string.Empty;

        public string Phone { get; private set; } = string.Empty;

        public DeanOffice() { }

        public static DeanOffice CreateEntity(int id, string name, string deanFullName, string phone)
        {
            return new DeanOffice
            {
                Id = id,
                Name = name ?? string.Empty,
                DeanFullName = deanFullName ?? string.Empty,
                Phone = phone ?? string.Empty
            };
        }
    }
}
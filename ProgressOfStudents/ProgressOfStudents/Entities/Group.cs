using System.ComponentModel.DataAnnotations;

namespace ProgressOfStudents.Entities
{
    public class Group
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(20)]
        public string GroupNumber { get; private set; } = string.Empty;

        [Required]
        public int Course { get; private set; }

        [Required]
        public int StreamId { get; private set; }

        public Group() { }

        public static Group CreateEntity(int id, string groupNumber, int course, int streamId)
        {
            return new Group
            {
                Id = id,
                GroupNumber = groupNumber ?? string.Empty,
                Course = course,
                StreamId = streamId
            };
        }
    }
}
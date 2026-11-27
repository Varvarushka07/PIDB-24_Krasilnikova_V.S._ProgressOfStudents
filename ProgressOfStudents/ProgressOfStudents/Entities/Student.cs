using System;
using System.ComponentModel.DataAnnotations;
using ProgressOfStudents.Entities.Enums;

namespace ProgressOfStudents.Entities
{
    public class Student
    {
        [Key]
        public int Id { get; private set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; private set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        public string RecordBookNumber { get; private set; } = string.Empty;

        [Required]
        public int GroupId { get; private set; }

        [Required]
        public StudentStatus Status { get; private set; }

        public Student() { }

        public static Student CreateEntity(int id, string fullName, string recordBookNumber, int groupId, StudentStatus status)
        {
            return new Student
            {
                Id = id,
                FullName = fullName ?? string.Empty,
                RecordBookNumber = recordBookNumber ?? string.Empty,
                GroupId = groupId,
                Status = status
            };
        }
    }
}
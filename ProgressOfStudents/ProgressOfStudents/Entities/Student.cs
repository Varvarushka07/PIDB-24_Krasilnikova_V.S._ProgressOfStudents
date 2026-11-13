using ProgressOfStudents.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class Student
{
    public int Id { get; private set; }
    public string FullName { get; private set; } = string.Empty;
    public string RecordBookNumber { get; private set; } = string.Empty;
    public int GroupId { get; private set; }
    public StudentStatus Status { get; private set; }

    public static Student CreateEntity(int id, string fullName, string recordBookNumber,
        int groupId, StudentStatus status)
    {
        if (status == StudentStatus.None)
            throw new ArgumentException("Статус студента не может быть пустым",
                nameof(status));

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



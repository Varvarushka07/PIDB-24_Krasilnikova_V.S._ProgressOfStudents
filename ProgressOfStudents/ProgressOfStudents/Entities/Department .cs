using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class Department
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public int DeanOfficeId { get; private set; }
    public string HeadFullName { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;


    public static Department CreateEntity(int id, string name, int deanOfficeId, string headFullName, string phone)
    {
        return new Department
        {
            Id = id,
            Name = name ?? string.Empty,
            DeanOfficeId = deanOfficeId,
            HeadFullName = headFullName ?? string.Empty,
            Phone = phone ?? string.Empty
        };
    }
}
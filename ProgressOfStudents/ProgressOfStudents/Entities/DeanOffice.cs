using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class DeanOffice
{
    public int Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string DeanFullName { get; private set; } = string.Empty;
    public string Phone { get; private set; } = string.Empty;

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
using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class DeanOfficeRepository : IDeanOfficeRepository
{
    public void CreateDeanOffice(DeanOffice deanOffice)
    {
    }

    public void DeleteDeanOffice(int id)
    {
    }

    public DeanOffice ReadDeanOfficeById(int id)
    {
        return DeanOffice.CreateEntity(0, string.Empty, string.Empty, string.Empty);
    }

    public IEnumerable<DeanOffice> ReadDeanOffices()
    {
        return new List<DeanOffice>();
    }

    public void UpdateDeanOffice(DeanOffice deanOffice)
    {
    }
}
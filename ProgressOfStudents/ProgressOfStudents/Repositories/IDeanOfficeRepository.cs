using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface IDeanOfficeRepository
{
    IEnumerable<DeanOffice> ReadDeanOffices();
    DeanOffice ReadDeanOfficeById(int id);
    void CreateDeanOffice(DeanOffice deanOffice);
    void UpdateDeanOffice(DeanOffice deanOffice);
    void DeleteDeanOffice(int id);
}
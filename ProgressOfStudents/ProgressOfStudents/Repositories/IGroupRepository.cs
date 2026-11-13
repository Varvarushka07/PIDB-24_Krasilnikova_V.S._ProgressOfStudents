using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories;

public interface IGroupRepository
{
    IEnumerable<Group> ReadGroups();
    void CreateGroup(Group group);
}

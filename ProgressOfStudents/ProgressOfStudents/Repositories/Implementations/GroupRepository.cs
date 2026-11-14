using ProgressOfStudents.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Repositories.Implementations;

internal class GroupRepository : IGroupRepository
{
    public void CreateGroup(Group group)
    {
    }

    public IEnumerable<Group> ReadGroups()
    {
        return [];
    }
}
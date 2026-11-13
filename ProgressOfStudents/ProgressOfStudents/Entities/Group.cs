using System;
using System.Collections.Generic;
using System.Text;

namespace ProgressOfStudents.Entities;

public class Group
{
    public int Id { get; private set; }
    public string GroupNumber { get; private set; } = string.Empty;
    public int Course { get; private set; }
    public int StreamId { get; private set; }

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
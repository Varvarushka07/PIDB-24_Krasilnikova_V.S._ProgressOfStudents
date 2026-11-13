using System;
using System.Collections.Generic;
using System.Text;
using StreamEntity = ProgressOfStudents.Entities.Stream;

namespace ProgressOfStudents.Repositories.Implementations;

internal class StreamRepository : IStreamRepository
{
    public void CreateStream(StreamEntity stream)
    {
    }

    public IEnumerable<StreamEntity> ReadStreams()
    {
        return [];
    }
}
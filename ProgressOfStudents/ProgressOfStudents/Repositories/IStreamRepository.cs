using System;
using System.Collections.Generic;
using System.Text;
using StreamEntity = ProgressOfStudents.Entities.Stream;

namespace ProgressOfStudents.Repositories;

public interface IStreamRepository
{
    IEnumerable<StreamEntity> ReadStreams();
    void CreateStream(StreamEntity stream);
}

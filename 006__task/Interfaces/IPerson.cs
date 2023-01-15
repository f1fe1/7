using System;

namespace _006__task.Interfaces
{
    internal interface IPerson : IIdNumber
    {
        string Name { get; }
        int Age { get; }
    }
}

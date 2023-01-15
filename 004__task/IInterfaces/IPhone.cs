using System;

namespace _004__task.IInterfaces
{
    public interface IPhone : IBrowse, ICall
    {
        string Email { get; }
    }
}

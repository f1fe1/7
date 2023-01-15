using _002__task;
using System;

namespace _001__task
{
    internal interface IPerson : IIdentifiable, IBirthday
    {
        string Name { get; }
        int Age { get; }
    }
}

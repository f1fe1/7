using System;

namespace _001__task
{
    internal class Person : IPerson
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime GetDateTime { get; set; }
        public int Id { get; set; }
    }
}

using _005__task.Interfaces;
using _005__task.Validator_and_Rules;
using System;
using System.Linq;

namespace _005__task.Person_and_Robot
{
    internal class Person : IPerson
    {
        private string _name = "Undefined";
        private string _id = "Undefined";
        private int _age = 0;
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name
        {
            get => _name;
            private set
            {
                Validator.ValidNotEmpty(value, nameof(this.Name));
                _name = value;
            }
        }

        public string Id
        {
            get => _name;
            private set
            {
                Validator.ValidNotEmpty(value, nameof(this.Id));
                Validator.ValidIsOnlyDigit(value, nameof(this.Id));
                _id = value;
            }
        }

        public int Age
        {
            get => _age;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception("Invalid! The age must be more than zero!");
                }
                _age = value;
            }
        }
    }
}

using _006__task.Interfaces;
using _006__task.Validator_and_Rules;
using System;

namespace _006__task.Domains
{
    internal class Person : IPerson
    {
        private string _name;
        private string _id;
        private int _age;
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }
        public virtual string Name
        {
            get => _name;   
            set
            {
                Validator.EmptyOrNull(value, nameof(this.Name));
                this._name = value;
            }
        }
        public virtual string Id
        {
            get => _id;
            set
            {
                Validator.EmptyOrNull(value, nameof(this.Id));
                Validator.OnlyDigit(value, nameof(this.Id));
                this._id = value;
            }
        }

        public virtual int Age
        {
            get => _age;
            set
            {
                Validator.AgeCheck(value, nameof(this.Age));
                this._age = value;  
            }
        }
    }
}

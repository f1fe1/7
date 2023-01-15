using System;
using _001__task;
using _001__task.Validator_and_Rules;

class Program
{
    static void Main()
    {
        Person[] people = new Person[]
        {
            new Person {Name = "Tomas", Age = 25},
            new Person {Name = "", Age = 30},
            new Person {Name = "James", Age = -10},
            new Person {Name = "", Age = 120}
        };

        MainValidator validator = new MainValidator();

        foreach(Person person in people)
        {
            var messages = validator.Errors(person);
            if (!messages.Any()) Console.WriteLine("Valid");
            else
                foreach(var message in messages)
                {
                    Console.WriteLine("Invalid " + message);
                }
        }
        


        Console.ReadLine();
    }
}
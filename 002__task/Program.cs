using System;
using _001__task;
using _001__task.Validator_and_Rules;
class Program
{
    static void Main()
    {
        Person[] people = new Person[]
        {
            new Person {Name = "Tomas", Age = 25, GetDateTime = new DateTime(2000,10, 25), Id = 00000000},
            new Person {Name = "James", Age = -25, GetDateTime = new DateTime(1955, 12, 10), Id = 00000001},
            new Person {Name = "", Age = 50, GetDateTime = new DateTime(2010, 10, 10), Id = 1}
        };

        MainValidator validator = new MainValidator();

        foreach (Person person in people)
        {
            var messages = validator.Errors(person);
            if (!messages.Any()) Console.WriteLine("Valid");
            else
                foreach (var message in messages)
                {
                    Console.WriteLine("Invalid " + message);
                }
        }



        Console.ReadLine();
    }
}
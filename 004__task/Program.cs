using _004__task.Fluent_Validator;
using _004__task.IInterfaces;
using _004__task.Smartphone;
using FluentValidation.Results;
using System;
class Program
{
    static void Main()
    {
        Smartphone[] smartphones = new Smartphone[]
        {
            new Smartphone {PhoneNumber = "+38-068-198-4590", URLAddress = "http::youtube.com", Email = "tkach.yevhenii@gmail.com"},
            new Smartphone {PhoneNumber = "+38-068-198-5025", URLAddress = "http::instagram.com", Email = "tkach. yevhenii@ukr.net"}
        };
        CustomerValidator validations = new CustomerValidator();

        foreach(Smartphone customer in smartphones)
        {
            ValidationResult result = validations.Validate(customer);

            if (!result.IsValid)
            {
                foreach (var failures in result.Errors)
                {
                    Console.WriteLine($"Property: {failures.PropertyName} failed validation. Error was: {failures.ErrorMessage}");
                }
            }
            else
            {
                Console.WriteLine(customer);
            }
        }

        Console.ReadLine();
    }
}

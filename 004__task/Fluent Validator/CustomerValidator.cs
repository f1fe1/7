using System;
using FluentValidation;
using _004__task.Smartphone;
using _004__task.IInterfaces;

namespace _004__task.Fluent_Validator
{
    public class CustomerValidator : AbstractValidator<IPhone>
    {
        public CustomerValidator()
        {
            RuleFor(smarthone => smarthone.PhoneNumber).NotEmpty();
            RuleFor(smarthone => smarthone.URLAddress).NotEmpty();
            RuleFor(smathone => smathone.Email).NotEmpty();   
            RuleFor(smathone => smathone.Email).EmailAddress();  
        }
    }
}

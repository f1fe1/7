using System;

namespace _001__task.Validator_and_Rules
{
    internal class MainValidator : ValidatorBase<IPerson>
    {
        protected override IEnumerable<ValidatorBase<IPerson>.Rule> Rules
        {
            get
            {
                return new Rule[]
                {
                    new Rule {Test = new Func<IPerson, bool>(foo => !string.IsNullOrEmpty(foo.Name)
                    && !string.IsNullOrWhiteSpace(foo.Name)), Message = "Name must be provided"},
                    new Rule {Test = new Func<IPerson, bool>(foo => foo.Age >= 0 && foo.Age <= 100), Message = "Age must be greater than zero"},
                    new Rule {Test = new Func<IPerson, bool>(function => function.Id.ToString().Length != 8), Message = "ID must me 8 numbers"},
                    new Rule {Test = new Func<IPerson, bool>(function => function.GetDateTime >= new DateTime(2000,1,1)), Message = "Birthday mast be more than 2000/01/01"}
                };
            }
        }
    }
}

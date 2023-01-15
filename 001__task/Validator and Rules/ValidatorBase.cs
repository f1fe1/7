using System;

namespace _001__task.Validator_and_Rules
{
    internal abstract class ValidatorBase<T>
    {
        public class Rule
        {
            public Func<T, bool> Test { get; set; }
            public string Message { get; set; }
        }
        protected abstract IEnumerable<Rule> Rules { get; }
        public IEnumerable<string> Errors(T t)
        {
            return this.Rules.Where(r => !r.Test(t)).Select(r => r.Message);    
        }
    }
}

using System;
using System.Linq;

namespace _005__task.Validator_and_Rules
{
    static public class Validator
    {
        public static void ValidNotEmpty(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"This type {type} is not valid!!!");
            }
        }

        public static void ValidIsOnlyDigit(string number, string type)
        {
            if (number.Any(a => char.IsLetter(a)) || number.Any(a => char.IsWhiteSpace(a)))
            {
                throw new ArgumentException($"This type {type} is not valid!!!");
            }
        }
    }
}

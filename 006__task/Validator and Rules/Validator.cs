using System;

namespace _006__task.Validator_and_Rules
{
    internal static class Validator
    {
        public static void EmptyOrNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException($"This string is null or empty {type}");
            }
        }
        public static void OnlyDigit(string value, string type)
        {
            if (value.All(char.IsDigit) && value.Length != 4) 
            {
                throw new FormatException($"This id number has wrong format and his lengh is not 4: {type}");
            }
        }
        public static void AgeCheck(int value, string type)
        {
            if (value.ToString().All(char.IsDigit) && value < 0 || value > 120)
            {
                throw new FormatException($"This age must be between 0 and 120 or you entered null string: {type}");
            }
        }
    }
}

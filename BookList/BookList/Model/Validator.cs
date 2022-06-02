using System;

namespace BookList.Model
{
    public class Validator
    {
        public static void AssertCountSymbolsInRange(string value, int min, int max, string nameProperty)
        {
            if (!(value.Length >= min && value.Length <= max))
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }

        public static void AssertReleaseYear(int value, int min, int max, string nameProperty)
        {
            if (value < min || value > max)
            {
                throw new AggregateException($"{nameProperty} the year does not match the {min} and {max} values ");
            }
        }
        
        public static void AssertOnPositiveValue(int value,string nameProperty)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field must be positive");
            }
        }
    }
}
using System;

namespace BookList.Model
{
    public class Validator
    {
        public static void AssertCountSymbolsInRange(string value, int min, int max, string nameProperty)
        {
            if (value.Length < min || value.Length > max)
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }
    }
}
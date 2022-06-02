using System;

namespace BookList.Model
{
    /// <summary>
    /// Представляет метод для проверки данных.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Проверяет, на кол-во символов в строке.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="nameProperty">Имя свойства вызванного метода.</param>
        /// <exception cref="ArgumentException">Возникает при несоответствии условию.</exception>
        public static void AssertCountSymbolsInRange(string value, int min, int max, string nameProperty)
        {
            if (!(value.Length >= min && value.Length <= max))
            {
                throw new ArgumentException($"{nameProperty} must be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет, год выпуска..
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="min">Минимальное значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="nameProperty">Имя свойства вызванного метода.</param>
        /// <exception cref="ArgumentException">Возникает при несоответствии условию.</exception>
        public static void AssertReleaseYear(int value, int min, int max, string nameProperty)
        {
            if (value < min || value > max)
            {
                throw new AggregateException($"{nameProperty} the year does not match the {min} and {max} values ");
            }
        }
        
        /// <summary>
        /// Проверяет, положительное число или нет.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="nameProperty">Имя свойства вызванного метода.</param>
        /// <exception cref="ArgumentException">Возникает при несоответствии условию.</exception>
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
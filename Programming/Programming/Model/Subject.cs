namespace Programming.Model
{
    using System;

    /// <summary>
    /// Хранит данные о дисциплине.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Оценка по дисциплине.
        /// </summary>  
        private int _mark;

        /// <summary>
        /// Количество академических часов дисциплины.
        /// </summary>
        private int _hoursCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название дисциплины.</param>
        /// <param name="hoursCount">Количество академических часов дисциплины. Должно быть положительным числом.</param>
        /// <param name="mark">Оценка по дисциплине. Должно быть в диапазоне от 0 до 5 (включительно).</param>
        public Subject(string name,
            int hoursCount,
            int mark)
        {
            Name = name;
            HoursCount = hoursCount;
            Mark = mark;
        }

        /// <summary>
        /// Возвращает и задаёт название дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт количество академических часов дисциплины. Должно быть положительным числом.
        /// </summary>
        public int HoursCount
        {
            get => _hoursCount;
            set
            {
                Validator.AssertOnPositiveValue(nameof(HoursCount), value);
                _hoursCount = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт оценку по дисциплине. Должно быть в диапазоне от 0 до 5 (включительно).
        /// </summary>
        public int Mark
        {
            get => _mark;
            set
            {
                Validator.AssertValueInRange(nameof(Mark), value, 0, 6);
                _mark = value;
            }
        }
    }
}
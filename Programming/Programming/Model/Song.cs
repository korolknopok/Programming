namespace Programming.Model
{
    using System;
    
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _durationSeconds;

        /// <summary>
        /// Создаёт экземпляр класса. <see cref="Song"/>.
        /// </summary>
        public Song()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="artist">Имя (псевдоним) музыканта.</param>
        /// <param name="name">Название песни.</param>
        /// <param name="durationSeconds">Продолжительность песни в секундах. Должно быть положительным числом.</param>
        public Song(string artist,
            string name,
            int durationSeconds)
        {
            Artist = artist;
            Name = name;
            DurationSeconds = durationSeconds;
        }

        /// <summary>
        /// Возвращает и задаёт имя (псевдоним) музыканта.
        /// </summary>
        public string Artist { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должно быть положительным числом.
        /// </summary>
        public int DurationSeconds
        {
            get
            {
                return _durationSeconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "the value of the Duration Seconds field must be greater than zero");
                }

                _durationSeconds = value;
            }
        }
    }
}
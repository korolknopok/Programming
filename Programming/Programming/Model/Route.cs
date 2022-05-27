namespace Programming.Model
{
    using System;
    
    /// <summary>
    /// Хранит данные о полёте.
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Время полёта в минутах.
        /// </summary>
        private int _flightTimeMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        public Route()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Route"/>.
        /// </summary>
        /// <param name="departure">Место отправления.</param>
        /// <param name="destination">Место прибытия.</param>
        /// <param name="flightTimeMinutes">Время полёта в минутах. Должно быть положительным числом.</param>
        public Route(string departure,
            string destination,
            int flightTimeMinutes)
        {
            Departure = departure;
            Destination = destination;
            FlightTimeMinutes = flightTimeMinutes;
        }

        /// <summary>
        /// Возвращает и задаёт место отправления.
        /// </summary>
        public string Departure { get; set; }
        
        /// <summary>
        /// Возвращает и задаёт место прибытия.
        /// </summary>
        public string Destination { get; set; }

        /// <summary>
        /// Возвращает и задаёт время полёта в минутах. Должно быть положительным числом.
        /// </summary>
        public int FlightTimeMinutes
        {
            get
            {
                return _flightTimeMinutes;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(
                        "the FlightTImeMinutes field must be greater than 0");
                }

                _flightTimeMinutes = value;
            }
        }
    }
}
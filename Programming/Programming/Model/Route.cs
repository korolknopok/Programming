namespace Programming.Model
{
    public class Route
    {
        private int _flightTimeMinutes;

        public Route()
        {
        }

        public Route(string departurePoint,
            string destinationPoint,
            int flightTimeMinutes)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
            FlightTimeMinutes = flightTimeMinutes;
        }

        public string DeparturePoint { get; set; }
        
        public string DestinationPoint { get; set; }

        public int FlightTimeMinutes
        {
            get { return _flightTimeMinutes; }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the FlightTImeMinutes field must be greater than 0");
                }

                _flightTimeMinutes = value;
            }
        }
    }
}
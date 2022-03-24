namespace Programming.Model
{
    public class Route
    {
        public Route()
        {

        }
        public Route(string departurePoint,
            string destinationPoint)
        {
            DeparturePoint = departurePoint;
            DestinationPoint = destinationPoint;
        }
        public string DeparturePoint { get; set; }
        public string DestinationPoint { get; set; }
    }
}
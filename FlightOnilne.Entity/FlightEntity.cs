namespace OnlineFlightBooking.Entity
{
    public class FlightEntity
    {
       public string FlightName { get; set; }
       public string FlightNumber { get; set; }
        public FlightEntity(string flightName,string flightNumber)
        {
            FlightName = flightName;
            FlightNumber = flightNumber;
        }
    }
}

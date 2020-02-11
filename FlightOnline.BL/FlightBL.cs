using OnlineFlightBooking.DAL;
using System.Data;
using OnlineFlightBooking.Entity;

namespace OnlineFlightBooking.BL
{
    public class FlightBL
    {
        public static void InsertFlight(FlightEntity flight)
        {
            FlightRepository.InsertFlight(flight);
        }
        public static void DeleteFlight(int id)
        {
            FlightRepository.DeleteFlight(id);
        }
        public static DataTable ViewFlightDetails()
        {
            DataTable dataTable = FlightRepository.ViewFlightDetails();
            return dataTable;
        }
        public static void UpdateFlight(int id, string flightName, string flightNumber)
        {
            FlightRepository.UpdateFlight(id,flightName,flightNumber);
        }
    }
}

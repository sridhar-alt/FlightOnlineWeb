using FlightOnline.DAL;
using System.Data;

namespace FlightOnline.BL
{
    public class FlightBL
    {
        public static void InsertFlight(string flightName, string flightNumber)
        {
            AdminRepository.InsertFlight(flightName, flightNumber);
        }
        public static void DeleteFlight(int id)
        {
            AdminRepository.DeleteFlight(id);
        }
        public static DataTable ViewFlightDetails()
        {
            DataTable dataTable = AdminRepository.ViewFlightDetails();
            return dataTable;
        }
        public static void UpdateFlight(int id, string flightName, string flightNumber)
        {
            AdminRepository.UpdateFlight(id,flightName,flightNumber);
        }
    }
}

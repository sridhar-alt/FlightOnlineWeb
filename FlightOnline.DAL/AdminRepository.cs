using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace FlightOnline.DAL
{
    public class AdminRepository
    {
        public static void InsertFlight(string flightName, string flightNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("FLIGHT_ADD", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@FLIGHTNAME", flightName);
                sqlCommand.Parameters.Add(param);
                param = new SqlParameter("@FLIGHTNUMBER", flightNumber);
                sqlCommand.Parameters.Add(param);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public static void DeleteFlight(int id)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE_FLIGHTDETAILS", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@FLIGHTID", id);
                sqlCommand.Parameters.Add(param);
                sqlCommand.ExecuteNonQuery();
            }
        }
        public static DataTable ViewFlightDetails()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from flightdb", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
        }
        public static void UpdateFlight(int id, string flightName, string flightNumber)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE_FLIGHTDB", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FLIGHTID", id);
                sqlCommand.Parameters.AddWithValue("@FLIGHTNAME", flightName);
                sqlCommand.Parameters.AddWithValue("@FLIGHTNUMBER", flightNumber);
                int i = sqlCommand.ExecuteNonQuery();
            }
        }
    }

}

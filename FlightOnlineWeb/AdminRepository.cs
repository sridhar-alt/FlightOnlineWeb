using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FlightOnlineWeb
{
    public class AdminRepository
    {
        //public static void DeleteFlight(int id)
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        //    using(SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        SqlCommand sqlCommand = new SqlCommand("DELETE_FLIGHTDETAILS", sqlConnection);
        //        SqlParameter param = new SqlParameter("@FLIGHTID", id);
        //        sqlCommand.Parameters.Add(param);
        //        sqlConnection.Open();
        //        sqlCommand.ExecuteNonQuery();
        //    }
        //}
        //public static DataTable ViewFlightDetails()
        //{
        //    string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        //    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
        //    {
        //        sqlConnection.Open();
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from flightdb", sqlConnection);
        //        DataTable dataTable = new DataTable();
        //        sqlDataAdapter.Fill(dataTable);
        //        return dataTable;
        //    }
        //}
    }
}
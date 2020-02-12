using OnlineFlightBooking.Entity;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OnlineFlightBooking.DAL
{
    public class UserRepository
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        public static Int16 ValidateLogin(string mobile, string password)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string sql = "SP_LOGIN";
                    SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter param = new SqlParameter("@MOBILENUMBER", mobile);
                    sqlCommand.Parameters.Add(param);
                    param = new SqlParameter("@PASSWORD", password);
                    sqlCommand.Parameters.Add(param);
                    sqlCommand.Parameters.Add("@ROLE", SqlDbType.VarChar, 15);
                    sqlCommand.Parameters["@ROLE"].Direction = ParameterDirection.Output;
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (Convert.ToString(sqlCommand.Parameters["@ROLE"].Value) == "admin")
                    {
                        return 1;
                    }
                    else if (Convert.ToString(sqlCommand.Parameters["@ROLE"].Value) == "user")
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch(Exception)
                {
                    return 0;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        public static Boolean RegisterUser(UserEntity user)
        {
            int row = 0;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string sql = "SP_USER_PROC_INSERT";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        SqlParameter param = new SqlParameter("@NAME", user.Name);
                        sqlCommand.Parameters.Add(param);
                        param = new SqlParameter("@MOBILENUMBER", user.Mobile);
                        sqlCommand.Parameters.Add(param);
                        param = new SqlParameter("@DOB", user.Dob);
                        sqlCommand.Parameters.Add(param);
                        param = new SqlParameter("@SEX", user.Sex);
                        sqlCommand.Parameters.Add(param);
                        param = new SqlParameter("@USERADDRESS", user.UserAddress);
                        sqlCommand.Parameters.Add(param);
                        param = new SqlParameter("@PASSWORD", user.Password);
                        sqlCommand.Parameters.Add(param);
                        param = new SqlParameter("@MEMBERROLE", user.Role);
                        sqlCommand.Parameters.Add(param);
                        row = sqlCommand.ExecuteNonQuery();
                    }
                    if (row > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch(Exception)
                {
                    return false;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
        public static DataTable ViewFlightDetails()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    string sql = "SP_FLIGHT_DISPLAY";
                    using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                        sqlConnection.Open();
                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                        sqlDataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                catch (Exception)
                {
                    return dataTable;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }
    }
}

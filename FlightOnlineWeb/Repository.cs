using System;
using System.Configuration;
using System.Data.SqlClient;

namespace FlightOnlineWeb
{
    public class Repository
    {
        public Boolean ValidateLogin(string mobile, string password)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sql = "USER_PROC_LOGIN";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
            {
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        if ((dataReader.GetString(0) == mobile) && (dataReader.GetString(1) == password))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        public static Boolean RegisterUser(UserEntity user)
        {
            int row = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            string sql = "USER_PROC_INSERT";
            using (SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection))
            {
                sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter("@NAME", user.name);
                sqlCommand.Parameters.Add(param);
                param = new SqlParameter("@MOBILENUMBER",user.mobile);
                sqlCommand.Parameters.Add(param);
                param = new SqlParameter("@DOB", user.dob);
                sqlCommand.Parameters.Add(param);
                param = new SqlParameter("@SEX", user.sex);
                sqlCommand.Parameters.Add(param);
                param = new SqlParameter("@USERADDRESS", user.userAddress);
                sqlCommand.Parameters.Add(param);
                param = new SqlParameter("@PASSWORD", user.password);
                sqlCommand.Parameters.Add(param);
                row=sqlCommand.ExecuteNonQuery();
            }
            if(row>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
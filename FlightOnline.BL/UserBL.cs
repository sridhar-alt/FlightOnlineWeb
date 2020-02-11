using OnlineFlightBooking.Entity;
using OnlineFlightBooking.DAL;
using System;
using System.Data;

namespace OnlineFlightBooking.BL
{
    public class UserBL
    {
        public static Int16 ValidateLogin(string mobile, string password)
        {
            Int16 n = UserRepository.ValidateLogin(mobile, password);
            return n;
        }
        public static Boolean RegisterUser(UserEntity user)
        {
            Boolean result = UserRepository.RegisterUser(user);
            return result;
        }
        public static DataTable ViewFlightDetails()
        {
            DataTable dataTable = UserRepository.ViewFlightDetails();
            return dataTable;
        }
    }
}

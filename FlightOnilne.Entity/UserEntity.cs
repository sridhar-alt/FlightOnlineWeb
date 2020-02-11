using System;
namespace OnlineFlightBooking.Entity
{
    public class UserEntity
    {
        public string Name { get; set; }
        public long Mobile { get; set; }
        public DateTime Dob { get; set; }
        public string Mail { get; set; }
        public string Sex { get; set; }
        public string UserAddress { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public UserEntity(string name, long mobile, DateTime dob, string mail, string sex, string userAddress, string password)
        {
            Name = name;
            Mobile = mobile;
            Dob = dob;
            Mail = mail;
            Sex = sex;
            UserAddress = userAddress;
            Password = password;
            Role = "user";
        }
    }
}

using System;
namespace FlightOnlineWeb
{
    public class UserEntity
    {
        public string name { get; set; }
        public string mobile { get; set; }
        public DateTime dob { get; set; }
        public string mail { get; set; }
        public string sex { get; set; }
        public string userAddress { get; set; }
        public string password { get; set; }
        public UserEntity(string name,string mobile,DateTime dob,string mail,string sex,string userAddress,string password)
        {
            this.name = name;
            this.mobile = mobile;
            this.dob = dob;
            this.mail = mail;
            this.sex = sex;
            this.userAddress = userAddress;
            this.password = password;
        }
    }
}
using OnlineFlightBooking.Entity;
using OnlineFlightBooking.BL;
using System;
namespace OnlineFlightBookingWeb
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void adduser(object sender, EventArgs e)
        {
            string name = txtName.Text;
            long mobile = Convert.ToInt64(txtNumber.Text);
            DateTime dob = Convert.ToDateTime(txtDob.Text);
            string mail = txtMail.Text;
            string gender;
            if (txtMale.Checked)
                gender = txtMale.Text;
            else
                gender = txtFemale.Text;
            string userAddress = txtAddress.Text;
            string password = txtPassword.Text;
            UserEntity user = new UserEntity(name, mobile, dob, mail, gender, userAddress, password);
            if(UserBL.RegisterUser(user))
            {
                Response.Write("registered");
                Response.Redirect("LoginPage.aspx");
            }
            else
            {
                Response.Write("Mobile Number already Registered");
            }
        }
    }
}
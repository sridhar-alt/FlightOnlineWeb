using OnlineFlightBooking.BL;
using System;

namespace OnlineFlightBookingWeb
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adduser(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void Login(object sender, EventArgs e)
        {
            string mobile = txtMobile.Text;
            string password = txtPassword.Text;
            Int16 result = UserBL.ValidateLogin(mobile, password);
            if (result==1)
            {
                Response.Redirect("AdminPage.aspx");
            }
            else if(result==2)
            {
                Response.Write("USER PAGE Successfull");
            }
            else if(result==0)
            {
                Response.Write("lOGIN FAILED");
            }
        }
    }
}
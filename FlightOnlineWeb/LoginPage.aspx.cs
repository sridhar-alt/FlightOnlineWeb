using System;

namespace FlightOnlineWeb
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
            Repository repository = new Repository();
            string mobile = txtmobile.Text;
            string password = txtpassword.Text;
            bool result=repository.ValidateLogin(mobile,password);
            if(result)
            {
                Response.Write("Successfull");
            }
            else
            {
                Response.Write("lOGIN FAILED");
            }
        }
    }
}
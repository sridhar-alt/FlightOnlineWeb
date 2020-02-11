using OnlineFlightBooking.BL;
using System;
using System.Data;

namespace OnlineFlightBookingWeb
{
    public partial class ViewFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = UserBL.ViewFlightDetails();
            idFlightView.DataSource = dataTable;
            idFlightView.DataBind();
        }
    }
}
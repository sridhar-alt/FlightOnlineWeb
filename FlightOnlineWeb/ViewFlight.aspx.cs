using System;
using System.Data;

namespace FlightOnlineWeb
{
    public partial class ViewFlight : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable = UserRepository.ViewFlightDetails();
            idFlightView.DataSource = dataTable;
            idFlightView.DataBind();
        }
    }
}
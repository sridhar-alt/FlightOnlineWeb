using OnlineFlightBooking.BL;
using OnlineFlightBooking.Entity;
using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineFlightBookingWeb
{
    public partial class Adminpage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FillData();
            }
        }
        protected void FillData()
        {
            DataTable dataTable= FlightBL.ViewFlightDetails();
            idFlightView1.DataSource = dataTable;
            idFlightView1.DataBind();
        }
        protected void FlightView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            idFlightView1.EditIndex = e.NewEditIndex;
            FillData();
        }
        protected void FlightView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            idFlightView1.EditIndex = -1;
            FillData();
        }
        protected void FlightView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string txtFlightName = Convert.ToString((idFlightView1.Rows[e.RowIndex].FindControl("TxtFlightName") as TextBox).Text);
            string txtFlightNumber = Convert.ToString((idFlightView1.Rows[e.RowIndex].FindControl("TxtFlightNumber")as TextBox).Text);
            int id = Convert.ToInt16(idFlightView1.DataKeys[e.RowIndex].Values["flightId"].ToString());
            FlightBL.UpdateFlight(id, txtFlightName, txtFlightNumber);
            FillData();
        }
        protected void FlightView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Convert.ToInt16(idFlightView1.DataKeys[e.RowIndex].Values["flightId"].ToString());
            FlightBL.DeleteFlight(id);
            FillData();
        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            string txtFlightName = Convert.ToString((idFlightView1.FooterRow.FindControl("txtInsertFlightName") as TextBox).Text);
            string txtFlightNumber = Convert.ToString((idFlightView1.FooterRow.FindControl("txtInsertFlightNumber") as TextBox).Text);
            FlightEntity flightEntity = new FlightEntity(txtFlightName, txtFlightNumber);
            FlightBL.InsertFlight(flightEntity);
            FillData();
        }
    }
}
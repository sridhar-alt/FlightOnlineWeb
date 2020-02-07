using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlightOnlineWeb
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
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select * from flightdb", sqlConnection);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                idFlightView1.DataSource = dataTable;
                idFlightView1.DataBind();
            }
        }
        protected void idFlightView1_RowDeleting(object sender,GridViewDeletedEventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);
            int flightId = Convert.ToInt16(idFlightView1.DataKeys[e.RowIndex].Values["flightId"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from flightdb where @flightId =flightId", con);
            cmd.Parameters.AddWithValue("@FlightId",flightId);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            FillData();
        }
        protected void idFlightView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            idFlightView1.EditIndex = e.NewEditIndex;
            FillData();
        }
        protected void idFlightView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            idFlightView1.EditIndex = -1;
            FillData();
        }
    }
}
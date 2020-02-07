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
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString);

            string txtFlightName = Convert.ToString(idFlightView1.Rows[e.RowIndex].FindControl("flightName"));
            string txtFlightNumber = Convert.ToString(idFlightView1.Rows[e.RowIndex].FindControl("flightNumber"));
            int id = Convert.ToInt16(idFlightView1.DataKeys[e.RowIndex].Values["flightId"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE_FLIGHTDB", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FLIGHTID", id);
            cmd.Parameters.AddWithValue("@FLIGHTNAME", txtFlightName);
            cmd.Parameters.AddWithValue("@FLIGHTNUMBER", txtFlightNumber);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            idFlightView1.EditIndex = -1;
            FillData();
        }

        protected void FlightView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            int id = Convert.ToInt16(idFlightView1.DataKeys[e.RowIndex].Values["flightId"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from flightdb where @flightId =flightId", con);
            cmd.Parameters.AddWithValue("@FlightId", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            FillData();
        }
    }
}
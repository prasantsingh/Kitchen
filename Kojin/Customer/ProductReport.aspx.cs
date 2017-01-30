using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kojin.Customer
{
    public partial class ProductReport : System.Web.UI.Page
    {
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection();
            string objcon = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            con.ConnectionString = objcon;
            if (!IsPostBack)
            {
                SqlDataAdapter da = new SqlDataAdapter("PROC_GetDetails", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Repeater1.DataSource = dt;
                Repeater1.DataBind();

            }
        }

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "LoadCell1")
            {
                lblProduct.Text = "SUGAR";
            }
            if (e.CommandName == "LoadCell2")
            {
                lblProduct.Text = "PULSE";
            }
            if (e.CommandName == "LoadCell3")
            {
                lblProduct.Text = "AATA";
            }
            if (e.CommandName == "LoadCell4")
            {
                lblProduct.Text = "RAJMA";
            }
            if (e.CommandName == "LoadCell5")
            {
                lblProduct.Text = "RICE";
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("PROC_GetDetailsProductWise", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Cell", SqlDbType.VarChar).Value = e.CommandName.ToString();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Repeater2.DataSource = dt;
            Repeater2.DataBind();
            con.Close();
        }
    }
}
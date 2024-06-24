using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Tuition_Managment_System
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Excellent_Click(object sender, EventArgs e)
        {
         // Creating connections by using Sql connection class
         SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
        //Pass the query by using SqlDataAdapater class
        string q = "Display_Excellent";
        SqlDataAdapter da = new SqlDataAdapter(q, con);
        DataSet ds = new DataSet();
        da.Fill(ds, "student");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Btn_Average_Click(object sender, EventArgs e)
        {
            // Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Pass the query by using SqlDataAdapater class
            string q = "Display_Average";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void Btn_Poor_Click(object sender, EventArgs e)
        {
            // Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Pass the query by using SqlDataAdapater class
            string q = "Display_Poor";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}
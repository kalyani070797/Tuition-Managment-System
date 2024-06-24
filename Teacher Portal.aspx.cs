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
    public partial class Teacher_Portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Display_List_Student()
        {
            //Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Pass the query by using SqlDataAdapater class
            string q = "Display_Student";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "student");
            GridView1.DataSource = ds;
            GridView1.DataBind();
            Response.Write("List of student Details");


        }
        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            //Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Open connection
            con.Open();
            //Pass the query by using sqlcommand
            SqlCommand cmd = new SqlCommand("Teacher_Login", con);
            //Inform that we are using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Txt_UserId.Text);
            cmd.Parameters.AddWithValue("@name", Txt_Name.Text);
            //Execute the query by using ExecuteScalar method
            object p = cmd.ExecuteScalar();
            if((int)p!=0)
            {
                Response.Write("Teacher Login Successful");
                Lbl_msg.Visible = true;
                Lbl_msg.Text = "List of student Details";
                Display_List_Student();
            }
            else
            {
                Response.Write("Invalid details");

            }
            //Close connection
            con.Close();
        }
    }
}
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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        public void Teacher()
        {
            //Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Pass the query by using SqlDataAdapater class
            string q = "Display_Teacher";
            SqlDataAdapter da = new SqlDataAdapter(q, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "teacher");
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
        public void Student()
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

        }

        protected void Btn_Add_Click(object sender, EventArgs e)
        {
            //Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Connection open
            con.Open();
            //Pass the query by using SqlCommand
            string role = ddlReg.SelectedValue;
            string educationStatus = "";
            string query = "";
            if (role=="Student")
            {
                query = "Insert_Student";
                if (Rb_Excellent.Checked) educationStatus = "Excellent";
                else if (Rb_Good.Checked) educationStatus = "Good";
                else if (Rb_Average.Checked) educationStatus = "Average";
                else if (Rb_PooR.Checked) educationStatus = "Poor";
            }
            else if (role == "Teacher")

            {
                query = "Insert_Teacher";
                Lbl_Contact.Visible = true;
                Txt_Contact.Visible = true;
            }
            SqlCommand cmd = new SqlCommand(query, con);
            //Inform that we are using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", Txt_Name.Text);
            cmd.Parameters.AddWithValue("@address", Txt_Address.Text);
            cmd.Parameters.AddWithValue("@class", Txt_Class.Text);
            if (role== "Student")
            {
                cmd.Parameters.AddWithValue("@Educationstatus", educationStatus);
            }
            else //if(role=="Student")
            {
                cmd.Parameters.AddWithValue("@contact", Txt_Contact.Text);
            }
            //Execute the query by using ExecuteNonQuery()
            int p = cmd.ExecuteNonQuery();
            if(p!=0)
            {
                Response.Write("Registration Successful..");
            }
            else
            {
                Response.Write("Registration Unsuccessful..");
            }
            //Close conection
            con.Close();
            if (role == "Student")
            {
                Student();
            }
            else
            {
                Teacher();
            }


        }

        protected void ddlRole_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ddlReg.SelectedValue == "Student")
            {
                Lbl_EducationStatus.Visible = true;
                Rb_Excellent.Visible = true;
                Rb_Good.Visible = true;
                Rb_Average.Visible = true;
                Rb_PooR.Visible = true;
                Label1.Visible = true;
                Label1.Text = "Student Management";
            }
            else if (ddlReg.SelectedValue == "Teacher")
            {
                Lbl_EducationStatus.Visible = false;
                Rb_Excellent.Visible = false;
                Rb_Good.Visible = false;
                Rb_Average.Visible = false;
                Rb_PooR.Visible = false;
                Lbl_Contact.Visible = true;
                Txt_Contact.Visible = true;
                Label1.Visible = true;
                Label1.Text = "Teacher Management";
            }
            else
            {
                Lbl_EducationStatus.Visible = false;
            }
        }
    }
}
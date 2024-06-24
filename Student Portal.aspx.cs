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
    public partial class Student_Portal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            //Creating connections by using Sql connection class
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ToString());
            //Open connection
            con.Open();
            //Pass the query by using sqlcommand
            SqlCommand cmd = new SqlCommand("Student_Login", con);
            //Inform that we are using stored procedure
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Txt_UserId.Text);
            cmd.Parameters.AddWithValue("@name", Txt_Name.Text);
            //Execute the query by using ExecuteScalar method
            // string status = cmd.ExecuteScalar() as status;
            string status = cmd.ExecuteScalar() as string;

           
            if (status != null)
            {
                Lbl_Message.Text = GetMotivationalMessage(status);
            }
            else
            {
                Lbl_Message.Text = "Invalid username or password.";
            }
            //Close connection
            con.Close();
           
        }
        private string GetMotivationalMessage(string status)
        {
            switch (status.ToLower())
            {
                case "Excellent":
                    return "Keep up the great work!";
                case "Good":
                    return "You're doing well, keep pushing!";
                case "Average":
                    return "If you try more, you can be great at academics.";
                case "Poor":
                    return "Don't give up, you can improve!";
                default:
                    return "Welcome! Keep striving for success.";
            }
        }
    }
}

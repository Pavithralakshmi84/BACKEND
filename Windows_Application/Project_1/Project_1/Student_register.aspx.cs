using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Xml.Linq;

namespace Project_1.Properties
{
    public partial class Student_register : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }
        void LoadGrid()
        {
            // SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
            SqlCommand cmd = new SqlCommand("GetStudents", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            con.Close();
            
        }
        protected void BtnRegister_Click(object sender, EventArgs e)


        {
            //SqlCommand cmd = new SqlCommand("insert into Students (Name,Email,Password,Department,CGPA)values(@Name,@Email,@Password,@Department,@CGPA", con);
            SqlCommand cmd = new SqlCommand("sp_InsertStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", TxtName.Text);
            cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
            cmd.Parameters.AddWithValue("@Department", TxtDept.Text);
            cmd.Parameters.AddWithValue("@CGPA", TxtCGPA.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadGrid();
            con.Close();
            TxtName.Text = "";
            TxtEmail.Text = "";
            TxtPassword.Text = "";
            TxtDept.Text = "";
            TxtCGPA.Text = "";



            ClearForm();
            ShowMessage("Registration Successful!");
            Response.Redirect("StudentLogin.aspx");
        }
        private void ClearForm()
        {
            TxtName.Text = TxtEmail.Text = TxtPassword.Text = TxtDept.Text = TxtCGPA.Text = "";
        }
        private void ShowMessage(string message)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "alert", $"alert('{message}');", true);
        }

    }
}




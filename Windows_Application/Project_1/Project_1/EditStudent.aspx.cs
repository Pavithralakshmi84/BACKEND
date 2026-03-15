using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class EditStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentEmail"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
                return;
            }

            if (!IsPostBack)
            {
                LoadStudentDetails();
            }
        }

        private void LoadStudentDetails()
        {
            string email = Session["StudentEmail"].ToString();
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string sql = "SELECT Name, Email, Password, Department, CGPA FROM Students WHERE Email=@Email";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["Name"].ToString();
                    txtEmail.Text = reader["Email"].ToString();
                    txtPassword.Text = reader["Password"].ToString();
                    txtDepartment.Text = reader["Department"].ToString();
                    txtCGPA.Text = reader["CGPA"].ToString();
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = Session["StudentEmail"].ToString();
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();
                string sql = @"
                    UPDATE Students 
                    SET Name=@Name, Password=@Password, Department=@Department, CGPA=@CGPA
                    WHERE Email=@Email";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());
                cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());
                cmd.Parameters.AddWithValue("@CGPA", txtCGPA.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", email);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    lblMessage.CssClass = "text-success fw-bold";
                    lblMessage.Text = "Profile updated successfully!";
                    Session["StudentName"] = txtName.Text.Trim(); // update session name
                }
                else
                {
                    lblMessage.CssClass = "text-danger fw-bold";
                    lblMessage.Text = "Update failed. Please try again.";
                }
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentDashboard.aspx");
        }
    }
}

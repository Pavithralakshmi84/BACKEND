using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Project_1
{
    public partial class StudentLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nothing needed here for now, but you could add logic like clearing sessions
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Students WHERE Email=@Email AND Password=@Password", con);
                cmd.Parameters.AddWithValue("@Email", TxtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", TxtPassword.Text.Trim());

                con.Open();
                object result = cmd.ExecuteScalar();
                con.Close();

                if (result != null)
                {
                    // Store session values for dashboard
                    Session["StudentEmail"] = TxtEmail.Text.Trim();
                    Session["StudentName"] = result.ToString();

                    Response.Redirect("StudentDashboard.aspx");
                }
                else
                {
                    // Proper alert message
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid email or password');", true);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Student_register.aspx");
        }
    }
}

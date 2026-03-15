using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class CompanyLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Clear previous sessions on fresh page load
                Session.Clear();
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = TxtEmail.Text.Trim();
            string password = TxtPassword.Text.Trim();

            // Basic client-side validation
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ClientScript.RegisterStartupScript(this.GetType(), "validation",
                    "alert('Please enter both email and password');", true);
                return;
            }

            // Database connection
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Check if user exists and credentials match
                    string query = "SELECT COUNT(*) FROM Companies WHERE Email=@Email AND Password=@Password";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Login successful - store user info in Session
                            string companyQuery = "SELECT Name FROM Companies WHERE Email=@Email";
                            using (SqlCommand companyCmd = new SqlCommand(companyQuery, con))
                            {
                                companyCmd.Parameters.AddWithValue("@Email", email);
                                string companyName = companyCmd.ExecuteScalar().ToString();

                                // Session variables for dashboard use
                                Session["CompanyEmail"] = email;
                                Session["CompanyName"] = companyName;
                                Session["IsCompanyLoggedIn"] = true;
                            }

                            // Redirect to company dashboard
                            Response.Redirect("CompanyDashboard.aspx");
                        }
                        else
                        {
                            // Invalid credentials
                            ClientScript.RegisterStartupScript(this.GetType(), "loginError",
                                "alert('❌ Invalid email or password!');", true);
                            TxtPassword.Text = ""; // Clear password field
                        }
                    }
                }
                catch
                {
                    // Database connection error
                    ClientScript.RegisterStartupScript(this.GetType(), "dbError",
                        "alert('⚠️ Database connection error. Please try again later.');", true);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyRegister.aspx");
        }
    }
}
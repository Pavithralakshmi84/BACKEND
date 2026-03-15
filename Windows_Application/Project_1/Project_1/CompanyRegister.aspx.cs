using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Project_1
{
    public partial class CompanyRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text.Trim();
            string email = TxtEmail.Text.Trim();
            string password = TxtPassword.Text.Trim();
            string jobRole = TxtJobRole.Text.Trim();
            decimal cgpa = decimal.Parse(TxtCGPA.Text);

            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_InsertCompany", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;  // ✅ CRITICAL!

                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);
                        cmd.Parameters.AddWithValue("@JobRole", jobRole);
                        cmd.Parameters.AddWithValue("@EligibilityCGPA", cgpa);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "success",
                                "alert('✅ Company registered successfully!'); window.location='CompanyLogin.aspx';", true);
                        }
                        else
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "error",
                                "alert('Registration failed. Check data.');", true);
                        }
                    }
                }
                catch (Exception ex)
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "error",
                        $"alert('Error: {ex.Message}');", true);
                }
            }
        }
    }
}

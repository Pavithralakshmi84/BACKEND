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
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Session["CompanyEmail"] as string;
            if (string.IsNullOrEmpty(email))
            {
                Response.Redirect("CompanyLogin.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            if (!IsPostBack)
            {
                LoadCompanyProfile(email);
            }
        }
        private void LoadCompanyProfile(string email)
        {
            try
            {
                string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();
                    string sql = "SELECT Name, JobRole, EligibilityCGPA FROM Companies WHERE Email = @email";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCompanyName.Text = reader["Name"] == DBNull.Value ? "" : reader["Name"].ToString();
                                txtEmail.Text = email;
                                txtJobRole.Text = reader["JobRole"] == DBNull.Value ? "" : reader["JobRole"].ToString();
                                txtEligibilityCGPA.Text = reader["EligibilityCGPA"] == DBNull.Value ? "" : reader["EligibilityCGPA"].ToString();
                                Session["CompanyName"] = txtCompanyName.Text;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Error loading profile: " + ex.Message, "alert-danger");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string email = Session["CompanyEmail"] as string;
                if (string.IsNullOrEmpty(email))
                {
                    ShowMessage("Session expired. Please log in again.", "alert-danger");
                    return;
                }

                string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();
                    string sql = "UPDATE Companies SET Name=@name, JobRole=@jobrole, EligibilityCGPA=@cgpa WHERE Email=@email";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@name", txtCompanyName.Text.Trim());
                        cmd.Parameters.AddWithValue("@jobrole", txtJobRole.Text.Trim());

                        if (decimal.TryParse(txtEligibilityCGPA.Text, out var cgpa))
                            cmd.Parameters.AddWithValue("@cgpa", cgpa);
                        else
                            cmd.Parameters.AddWithValue("@cgpa", DBNull.Value);

                        cmd.Parameters.AddWithValue("@email", email);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            Session["CompanyName"] = txtCompanyName.Text.Trim();
                            ShowMessage("Profile updated successfully!", "alert-success");
                        }
                        else
                        {
                            ShowMessage("No changes made or profile not found.", "alert-warning");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Update failed: " + ex.Message, "alert-danger");
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            string email = Session["CompanyEmail"] as string;
            if (!string.IsNullOrEmpty(email))
            {
                LoadCompanyProfile(email);
                ShowMessage("Form reset to original values!", "alert-info");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyDashboard.aspx", false);
        }

        private void ShowMessage(string message, string cssClass)
        {
            lblMessage.Text = message;
            lblMessage.CssClass = $"alert {cssClass} mt-3";
            lblMessage.Visible = true;
        }
    }
}
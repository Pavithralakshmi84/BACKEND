using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace Project_1
{
    public partial class PostJob : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CompanyEmail"] == null)
                {
                    Response.Redirect("CompanyLogin.aspx");
                    return;
                }
                txtDeadline.Text = DateTime.Now.AddDays(30).ToString("yyyy-MM-dd");
            }
        }

        protected void btnPostJob_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtJobTitle.Text) || string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    ShowMessage("Job title and description required!", "alert-danger");
                    return;
                }

                string companyEmail = Session["CompanyEmail"].ToString();
                string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();

                    string sql = @"INSERT INTO Jobs 
                                   (CompanyEmail, JobTitle, Location, Description, Salary, Deadline, MaxApplications, PostedDate, Active)
                                   VALUES (@CompanyEmail, @JobTitle, @Location, @Description, @Salary, @Deadline, @MaxApplications, GETDATE(), 1)";

                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@CompanyEmail", companyEmail);
                        cmd.Parameters.AddWithValue("@JobTitle", txtJobTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@Location", txtLocation.Text.Trim());
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
                        cmd.Parameters.AddWithValue("@Salary", GetDecimalOrNull(txtSalary.Text));
                        cmd.Parameters.AddWithValue("@Deadline", DateTime.Parse(txtDeadline.Text));
                        cmd.Parameters.AddWithValue("@MaxApplications", GetIntOrDefault(txtMaxApps.Text, 100));

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            ShowMessage("✅ Job posted successfully! Redirecting...", "alert-success");
                            ClientScript.RegisterStartupScript(this.GetType(), "redirect",
                                "setTimeout(function(){window.location='CompanyDashboard.aspx';}, 2000);", true);
                        }
                        else
                        {
                            ShowMessage("Failed to post job.", "alert-danger");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ShowMessage("Error: " + ex.Message, "alert-danger");
            }
        }

        private decimal? GetDecimalOrNull(string value)
        {
            return decimal.TryParse(value, out decimal result) ? result : (decimal?)null;
        }

        private int GetIntOrDefault(string value, int defaultValue)
        {
            return int.TryParse(value, out int result) ? result : defaultValue;
        }

        private void ShowMessage(string message, string cssClass)
        {
            lblMessage.Text = message;
            lblMessage.CssClass = $"alert {cssClass} mt-3 w-100";
            lblMessage.Visible = true;
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class CompanyDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["CompanyEmail"] == null || Session["CompanyName"] == null)
                {
                    Response.Redirect("CompanyLogin.aspx");
                    return;
                }

                lblCompanyName.Text = Session["CompanyName"].ToString();
                LoadDashboardData();
            }
        }

        private void LoadDashboardData()
        {
            string companyEmail = Session["CompanyEmail"].ToString();
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                try
                {
                    con.Open();

                    // Total Jobs Posted
                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Jobs WHERE CompanyEmail=@Email AND Active=1", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", companyEmail);
                        lblTotalJobs.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // Total Applications
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*) FROM Applications a 
                        INNER JOIN Jobs j ON a.JobID = j.JobID 
                        WHERE j.CompanyEmail = @Email", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", companyEmail);
                        lblTotalApplications.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // New Applications (last 7 days)
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*) FROM Applications a 
                        INNER JOIN Jobs j ON a.JobID = j.JobID 
                        WHERE j.CompanyEmail = @Email AND a.AppliedDate >= DATEADD(day, -7, GETDATE())", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", companyEmail);
                        lblNewApplications.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // Shortlisted Applications
                    using (SqlCommand cmd = new SqlCommand(@"
                        SELECT COUNT(*) FROM Applications a 
                        INNER JOIN Jobs j ON a.JobID = j.JobID 
                        WHERE j.CompanyEmail = @Email AND a.Status = 'Shortlisted'", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", companyEmail);
                        lblShortlisted.Text = cmd.ExecuteScalar()?.ToString() ?? "0";
                    }

                    // Load Jobs Posted
                    LoadCompanyJobs(companyEmail, con);

                    // Load Recent Applications
                    LoadRecentApplications(companyEmail, con);

                    // Load Shortlisted Students
                    LoadShortlisted(companyEmail, con);
                }
                catch (Exception)
                {
                    lblTotalJobs.Text = lblTotalApplications.Text = lblNewApplications.Text = lblShortlisted.Text = "0";
                }
            }
        }

        private void LoadCompanyJobs(string companyEmail, SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT JobTitle, Location, Deadline, MaxApplications, PostedDate
                FROM Jobs
                WHERE CompanyEmail=@Email AND Active=1
                ORDER BY PostedDate DESC", con))
            {
                cmd.Parameters.AddWithValue("@Email", companyEmail);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvJobs.DataSource = dt;
                gvJobs.DataBind();
            }
        }

        private void LoadRecentApplications(string companyEmail, SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT TOP 5 
                    s.Name as StudentName, 
                    j.JobTitle as JobRole, 
                    s.CGPA, 
                    a.AppliedDate,
                    s.Email as StudentEmail
                FROM Applications a
                INNER JOIN Students s ON a.StudentEmail = s.Email
                INNER JOIN Jobs j ON a.JobID = j.JobID
                WHERE j.CompanyEmail = @Email
                ORDER BY a.AppliedDate DESC", con))
            {
                cmd.Parameters.AddWithValue("@Email", companyEmail);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvApplications.DataSource = dt;
                gvApplications.DataBind();
            }
        }

        private void LoadShortlisted(string companyEmail, SqlConnection con)
        {
            using (SqlCommand cmd = new SqlCommand(@"
                SELECT s.Name as StudentName, j.JobTitle, a.AppliedDate
                FROM Applications a
                INNER JOIN Students s ON a.StudentEmail = s.Email
                INNER JOIN Jobs j ON a.JobID = j.JobID
                WHERE j.CompanyEmail = @Email AND a.Status = 'Shortlisted'
                ORDER BY a.AppliedDate DESC", con))
            {
                cmd.Parameters.AddWithValue("@Email", companyEmail);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvShortlisted.DataSource = dt;
                gvShortlisted.DataBind();
            }
        }

        // GridView Events for Applications
        protected void gvApplications_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.CssClass += " table-hover-row";
                Button btnShortlist = e.Row.FindControl("btnShortlist") as Button;
                if (btnShortlist != null)
                {
                    string studentEmail = DataBinder.Eval(e.Row.DataItem, "StudentEmail")?.ToString();
                    btnShortlist.CommandArgument = studentEmail;
                }
            }
        }

        protected void gvApplications_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Shortlist")
            {
                string studentEmail = e.CommandArgument.ToString();

                string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Applications SET Status='Shortlisted' WHERE StudentEmail=@Email", con);
                    cmd.Parameters.AddWithValue("@Email", studentEmail);
                    cmd.ExecuteNonQuery();
                }

                // Refresh dashboard data
                LoadDashboardData();

                ClientScript.RegisterStartupScript(this.GetType(), "alert",
                    $"alert('Shortlisted {studentEmail}!');", true);
            }
        }

        // Navigation
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("CompanyLogin.aspx");
        }

        protected void btnPostJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("PostJob.aspx");
        }

        protected void btnViewApplications_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyApplications.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProfile.aspx");
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class StudentDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Ensure student is logged in
            if (Session["StudentEmail"] == null || Session["StudentName"] == null)
            {
                Response.Redirect("StudentLogin.aspx");
                return;
            }

            if (!IsPostBack)
            {
                lblStudentName.Text = Session["StudentName"].ToString();
                LoadApplications();
            }
        }

        private void LoadApplications()
        {
            string studentEmail = Session["StudentEmail"].ToString();
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                con.Open();

                string sql = @"
                    SELECT j.JobTitle, j.Company, j.Location, a.AppliedDate, a.Status
                    FROM JobApplications a
                    INNER JOIN NewJobs j ON a.JobID = j.JobID
                    WHERE a.StudentEmail=@Email
                    ORDER BY a.AppliedDate DESC";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Email", studentEmail);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    gvApplications.DataSource = dt;
                    gvApplications.DataBind();
                }
            }
        }

        // Navigate to Apply Job page
        protected void btnApplyJob_Click(object sender, EventArgs e)
        {
            Response.Redirect("ApplyJobs.aspx");
        }

        // Reload dashboard
        protected void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentDashboard.aspx");
        }

        // Navigate to Edit Student profile page
        protected void btnEditStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditStudent.aspx");
        }

        // Logout
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("StudentLogin.aspx");
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}

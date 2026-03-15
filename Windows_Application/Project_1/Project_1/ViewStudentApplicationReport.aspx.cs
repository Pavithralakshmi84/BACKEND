using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class ViewStudentApplicationReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadApplications();
            }
        }

        private void LoadApplications()
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
                throw new Exception("Connection string 'con' is missing in Web.config.");

            using (SqlConnection con = new SqlConnection(connStr))
            {
                // Join Applications with Jobs to get JobTitle and Company
                string query = @"
                    SELECT a.ApplicationID, a.StudentEmail, j.JobTitle, j.Company, a.Status, a.AppliedDate
                    FROM Applications a
                    INNER JOIN NewJobs j ON a.JobID = j.JobID
                    ORDER BY a.AppliedDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvApplications.DataSource = dt;
                gvApplications.DataBind();
            }
        }

        protected void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }
    }
}

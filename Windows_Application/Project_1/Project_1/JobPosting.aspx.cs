using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class JobPosting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadJobs();
            }
        }

        private void LoadJobs()
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
                return;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"SELECT JobID, JobTitle, Company, Location, EligibilityCGPA, PostedDate 
                                 FROM NewJobs 
                                 ORDER BY PostedDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvJobs.DataSource = dt;
                gvJobs.DataBind();
            }
        }

        protected void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }
    }
}

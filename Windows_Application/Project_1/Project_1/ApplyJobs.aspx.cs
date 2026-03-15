using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class ApplyJobs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindJobs(); // Load jobs from DB
            }
        }

        private void BindJobs()
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NewJobs", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvJobs.DataSource = dt;
                gvJobs.DataBind();
            }
        }

        protected void gvJobs_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Apply")
            {
                if (Session["StudentEmail"] == null)
                {
                    lblMessage.Text = "Please log in before applying for jobs.";
                    return;
                }

                int index = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvJobs.Rows[index];

                int jobId = Convert.ToInt32(row.Cells[0].Text); // JobID column
                string studentEmail = Session["StudentEmail"].ToString();

                ApplyForJob(jobId, studentEmail);

                string jobTitle = row.Cells[1].Text; // JobTitle column
                lblMessage.Text = $"You have successfully applied for {jobTitle}.";
            }
        }

        private void ApplyForJob(int jobId, string studentEmail)
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_ApplyJob", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobID", jobId);
                cmd.Parameters.AddWithValue("@StudentEmail", studentEmail);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        protected void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentDashboard.aspx");
        }
    }
}

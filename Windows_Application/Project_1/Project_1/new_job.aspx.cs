using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Project_1
{
    public partial class new_job : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindJobs(); // Load jobs from DB on first load
            }
        }

        protected void btnAddJob_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string company = txtCompany.Text.Trim();
            string location = txtLocation.Text.Trim();

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(company) && !string.IsNullOrEmpty(location))
            {
                AddJob(title, company, location, 7.0); // default eligibility CGPA
                txtTitle.Text = "";
                txtCompany.Text = "";
                txtLocation.Text = "";
            }
        }

        private void AddJob(string title, string company, string location, double eligibilityCGPA)
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("sp_AddNewJob", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobTitle", title);
                cmd.Parameters.AddWithValue("@Company", company);
                cmd.Parameters.AddWithValue("@Location", location);
                cmd.Parameters.AddWithValue("@EligibilityCGPA", eligibilityCGPA);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

            BindJobs(); // Refresh GridView after insert
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
    }
}

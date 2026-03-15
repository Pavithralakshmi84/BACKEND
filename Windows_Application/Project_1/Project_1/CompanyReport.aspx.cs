using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Project_1
{
    public partial class CompanyReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCompanies();
            }
        }

        private void LoadCompanies()
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
                throw new Exception("Connection string 'con' is missing in Web.config.");

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = "SELECT CompanyID, Name, Email, JobRole, EligibilityCGPA FROM Companies";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvCompanies.DataSource = dt;
                gvCompanies.DataBind();
            }
        }

        protected void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }
    }
}

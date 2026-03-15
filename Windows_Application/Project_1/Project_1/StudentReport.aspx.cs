using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Project_1
{
    public partial class StudentReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }

        private void LoadStudents()
        {
            // Get connection string from Web.config
            string connStr = ConfigurationManager.ConnectionStrings["con"]?.ConnectionString;

            if (string.IsNullOrEmpty(connStr))
            {
                throw new Exception("CampusDB connection string is missing in Web.config.");
            }

            using (SqlConnection con = new SqlConnection(connStr))
            {
                string query = @"SELECT StudentID, Name, Email, Department, CGPA FROM Students";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvStudents.DataSource = dt;
                gvStudents.DataBind();
            }
        }

        protected void btnBackDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDashboard.aspx");
        }
    }
}

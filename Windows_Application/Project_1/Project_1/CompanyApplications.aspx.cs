using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class CompanyApplications : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CompanyEmail"] == null)
            {
                Response.Redirect("CompanyLogin.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
                return;
            }

            lblCompanyName.Text = Session["CompanyName"]?.ToString() ?? Session["CompanyEmail"].ToString();

            if (!IsPostBack)
            {
                LoadApplications();
            }
        }

        private void LoadApplications()
        {
            string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connStr))
            {
                string sql = @"
                    SELECT a.ApplicationID, s.Name AS StudentName, s.Email AS StudentEmail,
                           s.CGPA, j.JobTitle, j.Location, a.AppliedDate, ISNULL(a.Status,'Pending') AS Status
                    FROM Applications a
                    INNER JOIN Jobs j ON a.JobID = j.JobID
                    INNER JOIN Students s ON a.StudentEmail = s.Email
                    WHERE j.CompanyEmail = @Email
                    ORDER BY a.AppliedDate DESC";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Email", Session["CompanyEmail"]);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvApplications.DataSource = dt;
                gvApplications.DataBind();
            }
        }

        protected void gvApplications_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Shortlist" || e.CommandName == "Reject")
            {
                int appId = Convert.ToInt32(e.CommandArgument);
                string status = e.CommandName == "Shortlist" ? "Shortlisted" : "Rejected";

                string connStr = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Applications SET Status = @Status WHERE ApplicationID = @Id", con);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", appId);
                    cmd.ExecuteNonQuery();
                }

                LoadApplications(); // refresh grid
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("CompanyLogin.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }

        protected string GetStatusClass(string status)
        {
            if (status == "Shortlisted") return "bg-success";
            if (status == "Rejected") return "bg-danger";
            return "bg-warning text-dark"; // Pending
        }
    }
}

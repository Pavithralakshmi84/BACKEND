using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_1
{
    public partial class AdminDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStudentReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentReport.aspx");
        }

        protected void btnCompanyReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyReport.aspx");
        }

        protected void btnViewStudentReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudentApplicationReport.aspx");
        }

        protected void btnJobPostingReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("JobPosting.aspx");

        }

        protected void btnShortlistReport_Click(object sender, EventArgs e)
        {
          Response.Redirect("Shortlist.aspx");
        }
    }
}
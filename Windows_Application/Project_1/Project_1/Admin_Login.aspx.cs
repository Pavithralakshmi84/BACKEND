using System;
using System.Web.UI;

namespace Project_1
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                pnlLogin.Visible = true;
                pnlMessage.Visible = false;
                Session.Clear();
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                ShowMessage("Please enter both username and password.", "danger");
                return;
            }

            // Hardcoded admin credentials
            if (username.Equals("Admin", StringComparison.OrdinalIgnoreCase)
                && password == "Admin@123")
            {
                // Login successful - store in session
                Session["AdminID"] = "1"; // static ID
                Session["AdminName"] = "Administrator";
                Session["IsAdmin"] = true;

                // Redirect to admin dashboard
                Response.Redirect("AdminDashboard.aspx");
            }
            else
            {
                ShowMessage("Invalid username or password!", "danger");
            }
        }

        private void ShowMessage(string message, string type)
        {
            pnlLogin.Visible = true;   // keep login panel visible
            pnlMessage.Visible = true; // show error panel
            lblMessage.CssClass = "alert alert-" + type + " alert-dismissible fade show";
            lblMessage.Text = message;
            lblMessage.Visible = true;
        }
    }
}

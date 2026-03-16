using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace mini_project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connStr = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username=@u AND Password=@p", con);
                cmd.Parameters.AddWithValue("@u", txtUsername.Text);
                cmd.Parameters.AddWithValue("@p", txtPassword.Text);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    Session["Admin"] = txtUsername.Text;
                    Response.Redirect("StudentList.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid login!";
                }

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Gridview
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con= new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        public void LoadGrid()
        {
           // SqlCommand cmd = new SqlCommand("Select * from Employee", con);
            SqlCommand cmd = new SqlCommand("GetEmployees", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGrid();

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int EmpId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

          //  SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmpId=@EmpId", con);
            SqlCommand cmd = new SqlCommand("sp_DeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpId", EmpId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadGrid();
        }



        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int EmpId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            string name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string email = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string salary = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;

           // SqlCommand cmd = new SqlCommand("UPDATE Employee SET Name=@Name, Email=@Email, Salary=@Salary WHERE EmpId=@EmpId", con);


            SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@EmpId", EmpId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            GridView1.EditIndex = -1;
            LoadGrid();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            LoadGrid();
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
           // SqlCommand cmd = new SqlCommand("insert into Employee (Name,Email,Salary)values(@Name,@Email,@Salary)", con);
            SqlCommand cmd = new SqlCommand("sp_InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", TxtName.Text);
            cmd.Parameters.AddWithValue("@Email", TxtEmail.Text);
            cmd.Parameters.AddWithValue("@Salary", TxtSalary.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadGrid();
            con.Close();
            TxtName.Text = "";
            TxtEmail.Text = "";
            TxtSalary.Text = "";
        }

        protected void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace Grid__crud
{
    public partial class Grid : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGrid();
            }
        }

        void LoadGrid()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
            //  SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            LoadGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int EmpId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE EmpId=@EmpId", con);
            //SqlCommand cmd = new SqlCommand("sp_DeleteEmployee", con);
            //cmd.CommandType = CommandType.StoredProcedure;

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

            SqlCommand cmd = new SqlCommand(
                "UPDATE Cutomer SET Name=@Name, Address=@Address, Phno=@Phno WHERE CustID=@CustID", con);


            //SqlCommand cmd = new SqlCommand("sp_UpdateEmployee", con);
            //cmd.CommandType = CommandType.StoredProcedure;


            cmd.Parameters.AddWithValue("@Name", TxtName);
            cmd.Parameters.AddWithValue("@Address", TxtAddress);
            cmd.Parameters.AddWithValue("@Phnno", TxtPhno);
            cmd.Parameters.AddWithValue("@CustID", TxtCustID);

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
            SqlCommand cmd = new SqlCommand("insert into Customer (Name,Address,Phno)values(@Name,@Address,@Phno)", con);
            //SqlCommand cmd = new SqlCommand("sp_InsertEmployee", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", TxtName.Text);
            cmd.Parameters.AddWithValue("@Address",TxtAddress.Text);
            cmd.Parameters.AddWithValue("@Phno", TxtPhno.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadGrid();
            con.Close();
            TxtName.Text = "";
            TxtAddress.Text = "";
            TxtPhno.Text = "";
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
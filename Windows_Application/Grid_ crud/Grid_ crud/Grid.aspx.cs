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
           // SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
              SqlCommand cmd = new SqlCommand("GetCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;
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
            int CustID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

         //   SqlCommand cmd = new SqlCommand("DELETE FROM Customer WHERE CustID=@CustID", con);
           SqlCommand cmd = new SqlCommand("sp_DeleteCustomer", con);
           cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustID", CustID);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadGrid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int CustID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

            string Name = ((TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0]).Text;
            string Address = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            long Phno = Convert.ToInt64(((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text);


            //SqlCommand cmd = new SqlCommand("UPDATE Customer SET Name=@Name, Address=@Address, Phno=@Phno WHERE CustID=@CustID", con);


            SqlCommand cmd = new SqlCommand("sp_UpdateCustomer", con);
          cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CustID", CustID);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phno", Phno);
            

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
            //SqlCommand cmd = new SqlCommand("insert into Customer (Name,Address,Phno)values(@Name,@Address,@Phno)", con);
            SqlCommand cmd = new SqlCommand("sp_InsertCustomer", con);
            cmd.CommandType = CommandType.StoredProcedure;

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
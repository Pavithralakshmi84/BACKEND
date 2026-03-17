using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace CustomerTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllCustomers", con); // ✅ declare cmd
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // GridView
                dataGridView1.DataSource = dt;

                // ListBox
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "Name";

                // ComboBox
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
                comboBox1.ValueMember = "CustomerID";
            }
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            LoadCustomers();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_UpdateCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(comboBox1.SelectedValue));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(txtAge.Text));
                cmd.Parameters.AddWithValue("@City", txtCity.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            LoadCustomers();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_DeleteCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(comboBox1.SelectedValue));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            LoadCustomers();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
              LoadCustomers();
        }
    }
}

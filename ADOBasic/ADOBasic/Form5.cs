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

namespace ADOBasic
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server = .;Initial Catalog = ADO;uid =sa;pwd=sql;");
        private void button1_Click(object sender, EventArgs e)
        {
                      
            SqlCommand cmd = new SqlCommand("InsEmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@eno", textBox1.Text);
            cmd.Parameters.AddWithValue("@ename", textBox2.Text);
            cmd.Parameters.AddWithValue("@desg", textBox3.Text);
            cmd.Parameters.AddWithValue("@salary", textBox4.Text);
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Rows Inserted Sucessfully.....");
            con.Close();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Server=.;Integrated Security=true;Initial Catalog=ADO;");
            SqlCommand cmd = new SqlCommand("p1 ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p33", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno", comboBox1.Text);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            textBox2.Text = dr[1].ToString();
            textBox3.Text = dr[2].ToString();
            textBox4.Text = dr[3].ToString();
            dr.Close();
            con.Close();
        }

        public void LoadData()
        {
            SqlCommand cmd = new SqlCommand("p1 ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "eno";
            con.Close();
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdEmp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@eno", comboBox1.Text);
            cmd.Parameters.AddWithValue("@ename", textBox2.Text);
            cmd.Parameters.AddWithValue("@desg", textBox3.Text);
            cmd.Parameters.AddWithValue("@salary", textBox4.Text);
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Rows Updated Sucessfully.....");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delemp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@eno", comboBox1.Text);
   
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Rows Deleted Sucessfully.....");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("p1 ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "ename";
            con.Close();
        }
    }
}

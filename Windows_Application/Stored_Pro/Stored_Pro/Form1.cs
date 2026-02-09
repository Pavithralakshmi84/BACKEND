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

namespace Stored_Pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        SqlConnection con = new SqlConnection("server =.;initial catalog = Student;uid = sa;pwd=sql;");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("InsertStudentDet", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.Parameters.AddWithValue("@Dept", textBox4.Text);
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + "Rows inserted sucessfully.....");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;integrated security=true;initial catalog=Student;");
            SqlCommand cmd = new SqlCommand("studentdisplay", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DelStudent1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + "Rows deleted sucessfully.....");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdStudent", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@StudentID", textBox1.Text);
            cmd.Parameters.AddWithValue("@StudentName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Age", textBox3.Text);
            cmd.Parameters.AddWithValue("@Dept", textBox4.Text);
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + "Rows update sucessfully.....");
            con.Close();
        }
    }
}

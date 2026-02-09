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
    public partial class Form6 : Form
    {
        public Form6()
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
    }
}

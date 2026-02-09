using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Form
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("provider = sqloledb;server=DESKTOP-7ML64CQ;uid=sa;pwd=sql;initial catalog=Student;");
            OleDbCommand cmd = new OleDbCommand("studentdisplay", con);
            con.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show(dr[0].ToString());
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=.;integrated security=true;initial catalog=Student;");
            SqlCommand cmd = new SqlCommand("studentdisplay", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            MessageBox.Show(dr[0].ToString());
        }
    }
}

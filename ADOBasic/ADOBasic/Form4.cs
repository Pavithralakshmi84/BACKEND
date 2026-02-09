using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOBasic
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Server=DESKTOP-MRCDCGC;uid=sa;pwd=sql;Initial Catalog=sample;");
        OleDbConnection con1 = new OleDbConnection("provider = sqloledb;Server=DESKTOP-MRCDCGC;uid=sa;pwd=sql;Initial Catalog=sample;");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("empdisplay ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());

            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand("empdisplay ", con1);
            con1.Open();
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());

            }
            con1.Close();
        }
    }
}

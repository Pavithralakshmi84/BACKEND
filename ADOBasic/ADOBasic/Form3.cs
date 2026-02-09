using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOBasic
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //OleDbConnection con = new OleDbConnection("provider = sqloledb;Server=DESKTOP-MRCDCGC;uid=sa;pwd=sql;Initial Catalog=sample;");
        OleDbConnection con = new OleDbConnection("provider=sqloledb;Server=.;Integrated Security=sspi;database=sample;");
        private void button1_Click(object sender, EventArgs e)
        {

            OleDbCommand cmd = new OleDbCommand("insert into emp values(1000,'John','Mgr',125000)", con);
            con.Open();
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Record Inserted Sucessfully....");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}

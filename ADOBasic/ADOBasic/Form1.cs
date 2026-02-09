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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;uid=sa;pwd=sql;Initial Catalog=sample;");
        // SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;uid=sa;pwd=sql;Initial Catalog=sample;");
        SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;Integrated Security=true;Initial Catalog=ADO;");
        private void button1_Click(object sender, EventArgs e)
        {       

            SqlCommand cmd = new SqlCommand("insert into emp values(1000,'John','Mgr',125000)",con);
            con.Open();
            int x=cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Record Inserted Sucessfully....");
            con.Close();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            SqlCommand cmd = new SqlCommand("select * from emp ", con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();           
            while (dr.Read())
            {
                MessageBox.Show(dr[0].ToString() + " " + dr[1].ToString() + " " + dr[2].ToString() + " " + dr[3].ToString());

            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {                 
            SqlCommand cmd = new SqlCommand("update emp set ename='John1',desg='GM',salary=150000 where eno=1000", con);
            con.Open();
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Record Updated  Sucessfully....");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {         

            SqlCommand cmd = new SqlCommand("delete from emp  where eno=1000", con);
            con.Open();
            int x = cmd.ExecuteNonQuery();
            MessageBox.Show(x + " Record Deleted  Sucessfully....");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

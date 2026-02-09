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

namespace Win_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;User Id=sa;Password=sql;Initial Catalog=Student;"))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Student_Det VALUES (1302,'john','30','HR')", con);
                con.Open(); 
                int X = cmd.ExecuteNonQuery();
                MessageBox.Show(X + " record inserted successfully.");
            }
            }
        
        
        

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;User Id=sa;Password=sql;Initial Catalog=Student;"))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Student_Det WHERE StudentID = @id", con);
                cmd.Parameters.AddWithValue("@id", 4); con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " record deleted successfully.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;User Id=sa;Password=sql;Initial Catalog=Student;");
            SqlCommand cmd = new SqlCommand("UPDATE Student_Det SET StudentName=@name, Dept=@dept WHERE StudentID=@id", con);
            {
                cmd.Parameters.AddWithValue("@name", "Jeeva");
                cmd.Parameters.AddWithValue("@dept", "IT");
                cmd.Parameters.AddWithValue("@id", 5);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show(rows + " record updated successfully.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=DESKTOP-7ML64CQ;User Id=sa;Password=sql;Initial Catalog=Student;");
            SqlCommand cmd = new SqlCommand("INSERT INTO Student_Det (StudentID, StudentName, Age, Dept) VALUES (@StudentID, @StudentName, @Age, @Dept)", con);
            {
                cmd.Parameters.AddWithValue("@StudentID", 2110);
                cmd.Parameters.AddWithValue("@StudentName", "John"); 
                cmd.Parameters.AddWithValue("@Age", 95); 
                cmd.Parameters.AddWithValue("@Dept", "HR"); con.Open(); 
                int rows = cmd.ExecuteNonQuery(); 
                MessageBox.Show(rows + " record inserted successfully.");
            }
        }
    }
}
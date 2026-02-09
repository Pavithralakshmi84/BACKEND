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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server=.;Integrated Security=true;Initial Catalog=sample;");
            SqlCommand cmd = new SqlCommand("select * from emp ", con);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Alex", Age = 20 },
                new Student { Id = 2, Name = "Emma", Age = 22 },
                new Student { Id = 3, Name = "Alex1", Age = 20 },
                new Student { Id = 4, Name = "Emma2", Age = 22 }
            };

            dataGridView1.DataSource = students;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Product");
            dt.Columns.Add("Price");

            dt.Rows.Add(1, "Laptop", 50000);
            dt.Rows.Add(2, "Mouse", 500);

            dataGridView1.DataSource = dt;
        }
    }
}

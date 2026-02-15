using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gridview
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public long MobileNo { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>()
            {
            new Student { Id = 1, Name = "Alex", Age = 20, MobileNo = 9876543210, Email = "alex@gmail.com", Address = "Chennai" },
                new Student { Id = 2, Name = "Emma", Age = 22, MobileNo = 8765432109, Email = "Emma@gmail.com", Address = "Chennai" },
                new Student { Id = 3, Name = "John", Age = 23, MobileNo = 9865432107, Email = "John@gmail.com", Address = "Chennai" },
                new Student { Id = 4, Name = "Jose", Age = 24, MobileNo = 9875432106, Email = "Jose@gmail.com", Address = "Chennai" },
                new Student { Id = 5, Name = "Jesy", Age = 25, MobileNo = 9876432105, Email = "Jesy@gmail.com", Address = "Chennai" }
        };
            GridView1.DataSource = students;
            GridView1.DataBind();
        }

       
        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            
                DataTable dt = new DataTable();
                dt.Columns.Add("Id");
                dt.Columns.Add("Product");
                dt.Columns.Add("Price");
                dt.Rows.Add(1, "Laptop", 50000);
                dt.Rows.Add(2, "Mouse", 500);
                dt.Rows.Add(3, "Keyboard", 1500);
                dt.Rows.Add(4, "Mobile", 25000);
                dt.Rows.Add(5, "TV", 35500);

                GridView1.DataSource = dt;   // or dataGridView1
                GridView1.DataBind();
            }
        
    }
}
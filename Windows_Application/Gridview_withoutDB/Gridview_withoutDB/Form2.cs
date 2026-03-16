using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gridview_withoutDB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class Customer
        {
            public int CustomerID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string City { get; set; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            
                // Create a list of customers
                List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = 1, Name = "Pavithra", Email = "pavi@example.com", City = "Chennai" },
                new Customer { CustomerID = 2, Name = "Arun", Email = "arun@example.com", City = "Bangalore" },
                new Customer { CustomerID = 3, Name = "Meena", Email = "meena@example.com", City = "Hyderabad" }
            };

                // Bind to GridView
                dataGridView1.DataSource = customers;
            }
    }
}

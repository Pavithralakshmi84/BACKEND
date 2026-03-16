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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a DataTable in memory
            DataTable dt = new DataTable();
            dt.Columns.Add("CustomerID", typeof(int));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("City", typeof(string));

            // Add sample rows
            dt.Rows.Add(1, "Pavithra", "pavi@example.com", "Chennai");
            dt.Rows.Add(2, "Arun", "arun@example.com", "Bangalore");
            dt.Rows.Add(3, "Meena", "meena@example.com", "Hyderabad");

            // Bind to GridView
            dataGridView1.DataSource = dt;
        }
    }
}

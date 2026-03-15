using System;
using System.Text;

namespace WebFormsDemo
{
    public partial class Sample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Runs when the page loads
            if (!IsPostBack)
            {
                lblMessage.Text = "Select items and click the button.";
            }
        }

        protected void btnClickMe_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // Get selected fruits
            sb.Append("Selected Fruits: ");
            foreach (var item in lstFruits.Items)
            {
                var listItem = (System.Web.UI.WebControls.ListItem)item;
                if (listItem.Selected)
                {
                    sb.Append(listItem.Text + " ");
                }
            }

            // Get selected color
            sb.Append("<br/>Selected Color: " + ddlColors.SelectedValue);

            lblMessage.Text = sb.ToString();
        }
    }
}

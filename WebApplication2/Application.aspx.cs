using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.Items.Add("Siria");
            DropDownList1.Items.Add("Germany");
            DropDownList1.Items.Add("Italy");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Application2.aspx");
            Application["Name"] = TextBox1.Text;
            Application["Age"] = TextBox2.Text;
            Application["Country"] = DropDownList1.Text;
            TextBox1.Text = "";
            TextBox2.Text = "";                      
        }
    }
}
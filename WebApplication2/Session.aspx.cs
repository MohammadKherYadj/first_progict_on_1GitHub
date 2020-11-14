using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Name"] = TextBox1.Text;
            Session["Age"] = TextBox3.Text;
            Session["Country"] = DropDownList1.Text;
            TextBox1.Text = "";
            TextBox3.Text = "";            
            Server.Transfer("Session2.aspx");       
        }       
    }
}
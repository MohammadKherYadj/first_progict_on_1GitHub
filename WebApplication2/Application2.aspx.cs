using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Application["Name"].ToString();
            string age = Application["Age"].ToString();
            string country = Application["Country"].ToString();
            Response.Write("Name : " + name+"<br> Age : "+age+"<Br> Country : "+country);
        }
    }
}
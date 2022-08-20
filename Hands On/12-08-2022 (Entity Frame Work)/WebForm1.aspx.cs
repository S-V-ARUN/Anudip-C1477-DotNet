using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BankingHandson1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = false;
            Label2.Visible = false;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            Button1.Visible = false;
            Label1.Visible = false;
            Label2.Visible = true;
        }
    }
}
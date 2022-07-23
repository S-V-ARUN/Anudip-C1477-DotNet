using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ARunWebsiteCreate
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int a;

     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Label2.Text = "Correct";
            }
            else
            {
                Label2.Text = "Incorrect";
            }
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_Session
{
    public partial class Employee : System.Web.UI.Page
    {
        string ename = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListItem l1 in ListBox1.Items)
            {
                if (l1.Selected)
                {
                    ename = ename + l1.Value ;
                }
            }
            TextBox2.Text = TextBox2.Text +"\n"+ ename;

        }

        
    }
}
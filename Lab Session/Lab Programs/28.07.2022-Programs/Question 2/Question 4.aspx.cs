using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_Session
{
    public partial class Question_4 : System.Web.UI.Page
    {
        string date;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible=true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
             date = TextBox1.Text;
        }

       
    }
}
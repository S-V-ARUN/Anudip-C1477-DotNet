using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_Session
{
    public partial class CalorieTracker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            double Gram;
            double cal, pro, fat, cho;
            double a = double.Parse(TextBox1.Text);
            if (DropDownList1.SelectedIndex == 1)
            {
                a *= 1000;
            }
            Gram = (a / 100) * 100;
            cal = (Gram / 100) * 239;
            pro = (Gram / 100) * 27;
            fat = (Gram / 100) * 14;
          
            Label7.Text = pro.ToString() + " g";
            Label8.Text = cal.ToString() + " cal";
            Label9.Text = fat.ToString() + " g";
            

        }
    }
}
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
        int a,a1,rem,rev = 0;

         void Check()
        {
            while (a != 0) { 
                rem = a % 10;
                a = a / 10;
                rev = (rev * 10)+ rem;
            }
            if(a == rev)
            {
                Result1.Text = "It it Palindrome";
            }
            else
            {
                Result1.Text = "It is not a Palindrome";
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
             a = int.Parse(TextBox1.Text);
            a1 = a;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            while (a != 0)
            {
                rem = a % 10;
                a = a / 10;
                rev = (rev * 10) + rem;
            }
            if (a1 == rev)
            {
                Result1.Text = "It is Palindrome";
            }
            else
            {
                Result1.Text = "It is not a Palindrome";
            }

        }

       
    }
}
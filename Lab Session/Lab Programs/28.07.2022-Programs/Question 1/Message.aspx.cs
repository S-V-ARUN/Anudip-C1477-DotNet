using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_Session
{
    public partial class Message : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label6.Text = TextBox2.Text;
            Label7.Text = "From " + TextBox1.Text;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                Label6.Font.Bold = true;
            }
            else
            {
                Label6.Font.Bold = false;
            }
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked)
            {
                Label6.Font.Italic = true;
            }
            else
            {
                Label6.Font.Italic = false;
            }
        }

        protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox3.Checked)
            {
                Label6.Font.Underline = true;
            }
            else
            {
                Label6.Font.Underline = false;
            }
        }
        protected void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox5.Checked)
            {
                Label7.Font.Bold = true;
            }
            else
            {
                Label7.Font.Bold = false;
            }
        }

        protected void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox7.Checked)
            {
                Label7.Font.Italic = true;
            }
            else
            {
                Label7.Font.Italic = false;
            }
        }

        protected void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox6.Checked)
            {
                Label7.Font.Underline = true;
            }
            else
            {
                Label7.Font.Underline = false;
            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
            {
                Label6.ForeColor = System.Drawing.Color.Red;
            }
            else if (RadioButtonList1.SelectedIndex == 1)
            {
                Label6.ForeColor = System.Drawing.Color.Yellow;

            }
            else if (RadioButtonList1.SelectedIndex == 2)
            {
                Label6.ForeColor = System.Drawing.Color.Blue;

            }
        }

        protected void RadioButtonList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList2.SelectedIndex == 0)
            {
                Label6.ForeColor = System.Drawing.Color.Green;
            }
            else if (RadioButtonList2.SelectedIndex == 1)
            {
                Label6.ForeColor = System.Drawing.Color.Black;

            }
            else if (RadioButtonList2.SelectedIndex == 2)
            {
                Label6.ForeColor = System.Drawing.Color.Pink;

            }


        }

        protected void RadioButtonList3_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (RadioButtonList3.SelectedIndex == 0)
            {
                Label7.ForeColor = System.Drawing.Color.Red;
            }
            else if (RadioButtonList3.SelectedIndex == 1)
            {
                Label7.ForeColor = System.Drawing.Color.Yellow;

            }
            else if (RadioButtonList3.SelectedIndex == 2)
            {
                Label7.ForeColor = System.Drawing.Color.Blue;

            }
        }

        protected void RadioButtonList4_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (RadioButtonList4.SelectedIndex == 0)
            {
                Label7.ForeColor = System.Drawing.Color.Green;
            }
            else if (RadioButtonList4.SelectedIndex == 1)
            {
                Label7.ForeColor = System.Drawing.Color.Black;

            }
            else if (RadioButtonList4.SelectedIndex == 2)
            {
                Label7.ForeColor = System.Drawing.Color.Pink;

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ArunWebsiteTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Calendar1.Visible = false;

        }

     

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            
          string name,Dob,email,mobile,gender,address,state,pincode,hobbies = "";
            name = NameTextBox.Text;
            Dob = DOBTextBox.Text;
            email = EmailTextBox.Text;
            mobile = MobileTextBox.Text;
            address = AddressTextBox.Text;
            pincode = Pincode.Text;


            if (RadioButtonList1.SelectedIndex == 0)
            {
                gender = RadioButtonList1.SelectedValue;
            }
            else if(RadioButtonList1.SelectedIndex == 1)
            {
                gender = RadioButtonList1.SelectedValue;
            }
            else
            {
                //DoNothing
            }
            if(State.SelectedIndex == 0)
            {
                state = State.SelectedValue;
            }
            else if(State.SelectedIndex == 1)
            {
                state = State.SelectedValue;
            }
            else if (State.SelectedIndex == 2)
            {
                state = State.SelectedValue;
            }
            else if (State.SelectedIndex == 3)
            {
                state = State.SelectedValue;
            }
            else
            {
                //do nothing
            }
            foreach(ListItem L1 in CheckBoxList1.Items)
            {
                if (L1.Selected)
                {
                    hobbies = hobbies + L1.Text + " ";
                }
            }
          
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Calendar1.Visible=true;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DOBTextBox.Text = Calendar1.SelectedDate.ToShortDateString();
        }
    }
}
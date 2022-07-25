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

        }

        

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            string name,Dob,email,mobile,gender,address,state,pincode,hobbies = "";
            name = NameTextBox.Text;
            NameOut.Text = name;
            Dob = DOBTextBox.Text;
            DobOut.Text = Dob;
            email = EmailTextBox.Text;
            EmailOut.Text = email;
            mobile = MobileTextBox.Text;
            MobileNoOut.Text = mobile;
            if (RadioButton1.Checked)
            {
                GenderOut.Text = "Male";
                
            }
            else
            {
                GenderOut.Text = "Female";
            }
            AddressOut.Text = AddressTextBox.Text;
            if (State.SelectedIndex == 0)
            {
                StateOut.Text = State.SelectedValue;
            }
            else if(State.SelectedIndex == 1)
            {
                StateOut.Text = State.SelectedValue;

            }
            else if(State.SelectedIndex == 2)
            {
                StateOut.Text = State.SelectedValue;
            }
            else if (State.SelectedIndex == 3)
            {
                StateOut.Text = State.SelectedValue;
            }
            else if(State.SelectedIndex == 4)
            {
                StateOut.Text = State.SelectedValue;
            }
            else
            {
                //donothing
            }
            Pinout.Text = Pincode.Text;
            if (eGames.Checked)
            {
                hobbies = ("eGames " + hobbies);
            }
            if (CheckBox1.Checked)
            {
                hobbies = ("Sports " + hobbies);
            }
            if (CheckBox2.Checked)
            {
                hobbies = ("Songs " + hobbies);
            }
            if (CheckBox3.Checked)
            {
                hobbies = ("Netflix " + hobbies);
            }
           HobbiesOut.Text = hobbies;
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
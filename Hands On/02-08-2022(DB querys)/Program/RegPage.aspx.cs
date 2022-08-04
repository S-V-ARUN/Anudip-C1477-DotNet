using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace DBweb
{
    public partial class RegPage : System.Web.UI.Page
    {
        SqlConnection com;
        SqlCommand cmd;
        string gen;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                Panel1.Visible = false;
                com = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = E:\\.NET\\ASP Dotnet\\DBweb\\DBweb\\App_Data\\EmpDB.mdf; Integrated Security = True");
                com.Open();
                cmd = new SqlCommand("insert into StudTable values (@p1,@p2,@p3,@p4,@p5,@p6)", com);
                cmd.Parameters.AddWithValue("@p1", TextBox1.Text);
                cmd.Parameters.AddWithValue("@p2", TextBox3.Text);
                if (RadioButtonList1.SelectedIndex == 0)
                {
                    gen = "Male";
                }
                else if (RadioButtonList1.SelectedIndex == 1)
                {
                    gen = "Female";
                }
                else if (RadioButtonList1.SelectedIndex == 2)
                {
                    gen = "Female";
                }
                else
                {
                    //doNothing
                }
                cmd.Parameters.AddWithValue("@p3", gen);
                cmd.Parameters.AddWithValue("@p4", TextBox5.Text);
                cmd.Parameters.AddWithValue("@p5", TextBox7.Text);
                cmd.Parameters.AddWithValue("@p6", TextBox2.Text);
                cmd.ExecuteNonQuery();
                Panel2.Visible = true;

            }
            catch(Exception ex)
            {
                Image1.Visible = false;
                Response.Write(ex);
            }
            finally
            {
                com.Close();
                
            }




        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
         

        }
    }
}
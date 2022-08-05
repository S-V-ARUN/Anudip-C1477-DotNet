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
    public partial class LoginPage : System.Web.UI.Page
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel3.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Panel2.Visible = false;
            try
            {
                connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\.NET\\ASP Dotnet\\DBweb\\DBweb\\App_Data\\EmpDB.mdf;Integrated Security=True");
                connection.Open();
                string a = TextBox4.Text;

                command = new SqlCommand("select Id,Student_Name,Father_Name,Gender,DOB,Phone_Number from StudTable where Phone_Number =" + TextBox3.Text + "AND Password = " + "'"+a+"'" , connection);
                reader = command.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                Panel3.Visible = true;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
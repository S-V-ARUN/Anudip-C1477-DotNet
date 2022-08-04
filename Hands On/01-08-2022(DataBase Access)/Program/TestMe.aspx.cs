using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DBMStest
{
    public partial class TestMe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Id1_Click(object sender, EventArgs e)
        {
            
            SqlConnection s = new SqlConnection(ConfigurationManager.ConnectionStrings["Con1"].ConnectionString);
            s.Open();
            SqlCommand cmd = new SqlCommand("insert into TestTable values (@a,@b)",s);
            cmd.Parameters.AddWithValue("@a",TextBox1.Text);
            cmd.Parameters.AddWithValue("@b",TextBox2.Text);
            cmd.ExecuteNonQuery();
            s.Close();
            TextBox1.Text = "";
            TextBox2.Text = "";

        }
    } 
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Banking
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel2.Visible = false;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Panel1.Visible = false;
            Panel2.Visible = true;

            using (BankingDBEntities db = new BankingDBEntities())
            {
                

                BankingTBL tbl = new BankingTBL();
                tbl.Name = TextBox1.Text;
                tbl.Account_Type = TextBox4.Text;
                tbl.Balance = int.Parse(TextBox2.Text);
                db.BankingTBLs.Add(tbl);
                db.SaveChanges();

            }
        }
    }
}
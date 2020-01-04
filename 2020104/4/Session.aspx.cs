using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Session : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] account = { "123", "321" };
        string[] password = { "123", "321" };
        for (int i = 0; i < account.Length; i++) {
            if (account[i] == TextBox1.Text && password[i] == TextBox2.Text) {
                Session["account"] = TextBox1.Text;
                Response.Redirect("Sessionserver.aspx");
            }
        }
    }
}
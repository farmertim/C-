using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sessionserver : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            if (Request.Cookies[Session["account"].ToString()] != null)
            {
                TextBox1.Text = Request.Cookies[Session["account"].ToString()]["name"];
                TextBox2.Text = Request.Cookies[Session["account"].ToString()]["phone"];
                TextBox3.Text = Request.Cookies[Session["account"].ToString()]["address"];
            }

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Session["account"] != null)
        {
            Response.Cookies[Session["account"].ToString()]["name"] = TextBox1.Text;
            Response.Cookies[Session["account"].ToString()]["phone"] = TextBox2.Text;
            Response.Cookies[Session["account"].ToString()]["address"] = TextBox3.Text;
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Server.Transfer("Session.aspx");
    }
}
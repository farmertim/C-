using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookies目的 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            TextBox2.Text = Session["name"].ToString();
            if (Request.Cookies[Session["name"].ToString()] != null)
            {
                Response.Write("<script>alert('" + Request.Cookies[Session["name"].ToString()].Value + "');</script>");
                TextBox1.Text = Request.Cookies[Session["name"].ToString()]["Grade"];
            }
            TextBox2.Enabled = false;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Cookies[Session["name"].ToString()].Value = TextBox2.Text;

        if (Request.Cookies[TextBox2.Text] != null)
        {
           
            Response.Cookies[TextBox2.Text]["Grade"] = TextBox1.Text;
        }
        }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("cookies.aspx");
    }
}
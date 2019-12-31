using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class practice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Label1.Text =( Convert.ToInt32(Label1.Text) + 1).ToString();
    }

    protected void Timer2_Tick(object sender, EventArgs e)
    {
        Label2.Text = (Convert.ToInt32(Label2.Text) + 1).ToString();
    }

    protected void Timer3_Tick(object sender, EventArgs e)
    {
        Label3.Text = (Convert.ToInt32(Label3.Text) + 1).ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label4.Text = "姓名:" + TextBox1.Text + "<br/>" + "電話:" + TextBox2.Text + "<br/>" + "訂位時間:" + TextBox3.Text;
    }

    protected void Timer4_Tick(object sender, EventArgs e)
    {
        Label5.Text= DateTime.Now.ToLongTimeString();
    }
}
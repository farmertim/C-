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

    //protected void Timer4_Tick(object sender, EventArgs e)
    //{
    //    Label5.Text = DateTime.Now.ToLongTimeString();
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {

        Label4.Text = "姓名:" + TextBox1.Text + "<br/>" + "電話:" + TextBox2.Text + "<br/>" + "訂位時間:" + DropDownList3.SelectedValue + DropDownList4.SelectedValue;
     
    }



    protected void Button2_Click(object sender, EventArgs e)
    {
        Label6.Text = "套餐:" + DropDownList1.SelectedValue + "<br/>" + "飲料:" + DropDownList2.SelectedValue;
       
    }




}
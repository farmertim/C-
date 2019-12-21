using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Data;

public partial class 新增運動內容 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ((TextBox)FormView1.FindControl("姓名TextBox")).Text = Request.QueryString["name"].ToString();
        
    }



 

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者頁面.aspx");
    }

    protected void InsertButton_Click1(object sender, EventArgs e)
    {
        ((Label)FormView1.FindControl("Label1")).Text = "資料上傳成功";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Boolean b=true;
        string str = ((TextBox)FormView1.FindControl("運動多久TextBox")).Text;
        if (str == "")
            b = false;
        str = ((TextBox)FormView1.FindControl("地點TextBox")).Text;
       if (str == "")
        {
            b = false;
        }
        str = ((TextBox)FormView1.FindControl("運動日期TextBox")).Text;
        if (str == "")
        {
            b = false;
        }
        if (b == true)
        {
            ((LinkButton)FormView1.FindControl("InsertButton")).Enabled = true;
            ((Label)FormView1.FindControl("Label1")).Text = "資料檢查成功";
        }
        else
        {
            ((LinkButton)FormView1.FindControl("InsertButton")).Enabled = false;
            ((Label)FormView1.FindControl("Label1")).Text = "資料填寫不全";
        }

    }

    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    { 

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 查詢飲食紀錄 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack){
            Label1.Visible = false;
            Label1.Text = Request.QueryString["姓名"].ToString();
    }
    }

    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者頁面.aspx");
    }
}
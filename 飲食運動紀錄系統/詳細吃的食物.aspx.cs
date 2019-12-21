using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vu_6vu4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

  

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("查詢飲食紀錄.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Gridview : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        switch (e.CommandName) {
            case "insert":
                Response.Write("<script>alert('insert')</script>");
                Label1.Text=GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text;
                break;
            case "delete1":
                Response.Write("<script>alert('delete')</script>");
                break;
        }
    }
}
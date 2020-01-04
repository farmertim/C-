using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;


public partial class practice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        n();
    }
    protected void n() {
        using (SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\MS_SQL_2012\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Order Details]", co);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "table");
            dt = ds.Tables["table"];
            GridView1.DataSource = dt;
            GridView1.DataBind();


        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        n();
    }

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int number =Convert.ToInt32( GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text);
        using (SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\MS_SQL_2012\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Order Details] where OrderID="+number, co);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "table");
            dt = ds.Tables["table"];
            string s = "";
            s += "<table border=1><tr><td>OrderID</td><td>ProductID</td><tr>";
            for(int i=0;i<dt.Rows.Count;i++) {
                s += "<tr><td>";
                s += dt.Rows[i]["OrderID"].ToString()+"</td><td>";
                s += dt.Rows[i]["ProductID"].ToString()+"</td>"+"</tr>";

            }




            s += "</table>";
            Label1.Text = s;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class practice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True")) {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select*from 客戶資料", co);
            DataSet ds = new DataSet();
            da.Fill(ds, "name");
           DataTable dt = ds.Tables["name"];
            DataRow[] dr = ds.Tables["name"].Select();
            GridView1.DataSource=dr.CopyToDataTable();
            GridView1.DataBind();
            String s = "";
            for (int i = 0; i < ds.Tables["name"].Rows.Count; i++) {
                s += "<br/>" + ds.Tables["name"].Rows[i]["Id"].ToString();
            }
            Response.Write(s);
            DataView dv = new DataView(dt, "姓名='123'", "密碼,帳號", DataViewRowState.CurrentRows);
            GridView2.DataSource = dv;
            GridView2.DataBind();
        }
    }
}
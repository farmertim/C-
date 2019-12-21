using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class 查詢運動紀錄 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True;MultipleActiveResultSets=True"))
            {
                co.Open();
                SqlCommand cmd = new SqlCommand("SELECT 姓名,運動項目,運動日期 FROM 運動紀錄 where 姓名=('" + Request.QueryString["姓名"].ToString() + "') ", co);
                // cmd.Parameters.Add("@name1", SqlDbType.NVarChar, 10).Value = Request.QueryString["name"].ToString();
                //  cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();

                GridView2.DataSource = rd;
                GridView2.DataBind();
            }
        }
        catch (Exception es) {
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("使用者頁面.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("使用者頁面.aspx?姓名="+ Request.QueryString["姓名"].ToString());
    }
}
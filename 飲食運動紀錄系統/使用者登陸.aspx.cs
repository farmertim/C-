using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class 使用者登陸 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = 1,check=0;
        try
        {
           
            string str = "";
            using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True;MultipleActiveResultSets=true"))
            {


                co.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT*FROM 客戶資料 WHERE 帳號=@account AND 密碼=@password", co);
                da.SelectCommand.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = TextBox1.Text.ToString();
                da.SelectCommand.Parameters.Add("@password", SqlDbType.NVarChar, 10).Value = TextBox2.Text.ToString();
                
                DataSet ds = new DataSet();
                da.Fill(ds, "account");
                DataTable dt = ds.Tables["account"];
                if (dt.Rows.Count == 0)//判斷有無列
                {
                    Response.Write("<script>alert('無此帳密')</script>");
                    a = 0;
                }
                else
                {
                    if (dt.Rows[0]["姓名"].ToString() == "teacher")
                    {
                        check = 1;
                    }
                    str = dt.Rows[0]["姓名"].ToString();
                    Session["姓名"] = str;
                }
            }
        }
        catch (Exception ex)
        {
            a = 0;
            Response.Write("<script>alert('錯誤" + ex.ToString() + "')</script>");
        }
        if (a == 1)
        {
            if (check == 1)
            {
                Response.Redirect("管理員.aspx");
            }
            else
            {
                Response.Redirect("使用者頁面.aspx?姓名=" + Session["姓名"].ToString());
            }
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("新增帳號.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Server.Transfer("Forget.aspx");
    }
}
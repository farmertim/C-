using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Data;

public partial class 新增帳號 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        Response.Redirect("使用者登陸.aspx");
    }

 



    protected void FormView2_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {

    }



    protected void InsertButton_Click1(object sender, EventArgs e)
    {
        

    }

   

   

    protected void InsertButton_Click(object sender, EventArgs e)
    {
        ((Label)FormView2.FindControl("Label1")).Text = "資料上傳成功";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            int a = 0;
            if (string.IsNullOrEmpty(((TextBox)FormView2.FindControl("姓名TextBox")).Text))
            {
                ((Label)FormView2.FindControl("Label1")).Text = "資料填寫不完全";
                a = 1;
            }
            else if (string.IsNullOrEmpty(((TextBox)FormView2.FindControl("帳號TextBox")).Text))
            {
                ((Label)FormView2.FindControl("Label1")).Text = "資料填寫不完全";
                a = 1;
            }
            else if (string.IsNullOrEmpty(((TextBox)FormView2.FindControl("密碼TextBox")).Text))
            {
                ((Label)FormView2.FindControl("Label1")).Text = "資料填寫不完全";
                a = 1;
            }
            if (a == 0)
            {
                int user = 0;
                using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True;MultipleActiveResultSets=True"))
                {
                    co.Open();
                    SqlCommand cmd = new SqlCommand("select*from 客戶資料 where 姓名=@name OR 帳號=@account", co);
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 20).Value = ((TextBox)FormView2.FindControl("姓名TextBox")).Text;
                    cmd.Parameters.Add("@account", SqlDbType.NVarChar, 20).Value = ((TextBox)FormView2.FindControl("帳號TextBox")).Text;
                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows == false)
                    {
                        user = 0;
                    }
                    else {
                        user = 1;
                    }
                }
                if (user == 0)
                {
                    ((LinkButton)FormView2.FindControl("InsertButton")).Enabled = true;
                    ((Label)FormView2.FindControl("Label1")).Text = "資料檢查成功";
                }
                else
                {
                    ((Label)FormView2.FindControl("Label1")).Text = "已有帳號OR姓名";
                }
            }
            else
            {
                ((LinkButton)FormView2.FindControl("InsertButton")).Enabled = false;
            }
        }catch(Exception es)
        {
            ((Label)FormView2.FindControl("Label1")).Text = "資料上傳錯誤";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Forget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Boolean b = true;
        int check=0;
        if (TextBox1.Text == "")
        {
            b = false;
            Label1.Text = "資料驗證錯誤";
        }
        else if (TextBox2.Text == "")
        {
            b = false;
            Label1.Text = "資料驗證錯誤";
        }
        else if (TextBox3.Text == "")
        {
           
            Label1.Text = "資料驗證錯誤";
        }
        else if (TextBox2.Text != TextBox3.Text)
        {
            b = false;
            Label1.Text = "資料驗證錯誤";
        }
        if (b == true)
        {
            try
            {
                using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True;MultipleActiveResultSets=True"))
                {
                    co.Open();
                    SqlCommand cmd = new SqlCommand("SELECT* FROM 客戶資料 where 帳號=@account ", co);
                    SqlDataReader rd =cmd.ExecuteReader();
                    if (rd.HasRows == false) {
                        check = 1;
                    }
                }
            }
            catch (Exception es)
            {

            }
            if (check == 0)
            {
                try
                {
                    using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True;MultipleActiveResultSets=True"))
                    {
                        co.Open();
                        SqlCommand cmd = new SqlCommand("Update  客戶資料 set 密碼=@password where 帳號=@account ", co);


                        cmd.Parameters.Add("@account", SqlDbType.NVarChar, 20).Value = TextBox1.Text.ToString();
                        cmd.Parameters.Add("@password", SqlDbType.NVarChar, 20).Value = TextBox2.Text.ToString();
                        Label1.Text = "資料更新成功";
                        cmd.ExecuteNonQuery();

                    }
                }
                catch (Exception es)
                {

                }
            }else
            {
                Label1.Text = "無此資料，去註冊";
            }
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者登陸.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 查詢體態紀錄 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Visible = false;
        Label1.Visible = false;
        Label3.Visible = false;
        Label4.Visible = false;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int check = 0,a=0,powerd=0,basic=0,weight=0,pro=0,check1=0;
        try
        {
            using (SqlConnection c1 = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
            {
                c1.Open();
                SqlCommand cm = new SqlCommand("SELECT 熱量,蛋白質 FROM 飲食紀錄 where 日期='" + TextBox1.Text + "'" + "AND 姓名=@name", c1);
                cm.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Request.QueryString["姓名"].ToString();
                SqlDataReader cd = cm.ExecuteReader();
                if (cd.HasRows == false)//判斷有無列
                {
                    a = 1;
                }
                if (a == 0)
                {
                    while (cd.Read())
                    {
                        powerd += Convert.ToInt32(cd["熱量"]);
                        pro += Convert.ToInt32(cd["蛋白質"]);
                    }
                }

            }
            string str = "", name = "";
            int h = 0, pow = 0;
            Double bm = 0.0;
            DateTime day = Convert.ToDateTime("2000/05/26");
            using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
            {
                co.Open();
                SqlCommand cmd = new SqlCommand("select 姓名, 身高,bmi, 剩餘熱量,體重,基礎代謝率,日期 from 體態紀錄 where 日期=('" + TextBox1.Text + "')" + "AND 姓名=@name", co);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Request.QueryString["姓名"].ToString();
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows == false)
                {
                    check1 = 1;
                }
                if (check1 == 0)
                {
                    while (rd.Read())
                    {
                        name = Convert.ToString(rd["姓名"]);
                        pow = Convert.ToInt32(rd["剩餘熱量"]);
                        bm = Convert.ToDouble(rd["bmi"]);
                        h = Convert.ToInt32(rd["身高"]);
                        basic = Convert.ToInt32(rd["基礎代謝率"]);
                        weight = Convert.ToInt32(rd["體重"]);
                        day = Convert.ToDateTime(rd["日期"]);
                    }
                    str += "<table border=1 ><tr><td>姓名</td><td>身高</td><td>體重</td><td>MMI</td><td>基礎代謝率</td><td>日期</td></tr>";
                    str += "<tr><td>" + name.ToString() + "</td>" + "<td>" + h + "</td>" + "<td>" + weight + "</td>" + "<td>" + bm + "</td>" + "<td>" + basic + "</td>" + "<td>" + day.ToString() + "</td>" + "</tr>";
                    Label5.Text = str;
                }
                else
                {
                    Response.Write("<script>alert('查無日期')</script>");
                }
            }
            Response.Write("<script>alert('basic=" + basic + "power" + powerd + "')</script>");
            Label4.Visible = true;
            Label3.Visible = true;
            Label2.Visible = true;
            Label1.Visible = true;
            int sum = basic - powerd;
            Label2.Text = Convert.ToString(sum);
            int check2 = Convert.ToInt32(weight) * 2 - pro;
            Label1.Text = Convert.ToString(check2);
        }catch(Exception es)
        {

        }
        
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者頁面.aspx");
    }
}
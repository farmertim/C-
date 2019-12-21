using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class 體態紀錄 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Text = "資料填寫不完全";
        }
        else if (TextBox2.Text == "")
        {
            Label1.Text = "資料填寫不完全";
        }
        else if (TextBox5.Text == "")
        {
            Label1.Text = "資料填寫不完全";
        }
        else if (TextBox4.Text == "")
        {
            Label1.Text = "資料填寫不完全";
        }
        else
        {
            int powerd = 0, a = 0, basic = 0;
            try
            {
                using (SqlConnection c = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
                {
                    c.Open();
                    SqlCommand cm = new SqlCommand("SELECT 熱量 FROM 飲食紀錄 where 日期='" + TextBox5.Text + "'" + "AND 姓名=@name", c);
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
                        }
                    }

                }
            }
            catch (Exception es)
            {
                Label1.Text = "資料讀取錯誤";
            }

            try
            {
                using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
                {

                    //
                    co.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO 體態紀錄 (姓名,身高,體重,bmi,基礎代謝率,剩餘熱量,日期) values (@name,@h,@w,@BMI,@basic,@power,@day)", co);
                    if (Session["姓名"] != null)
                    {
                        cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = Session["姓名"].ToString();
                    }
                    cmd.Parameters.Add("@h", SqlDbType.Int, 10).Value = Convert.ToInt32(TextBox1.Text);
                    cmd.Parameters.Add("@w", SqlDbType.Int, 10).Value = Convert.ToInt32(TextBox2.Text);
                    cmd.Parameters.Add("@day", SqlDbType.Date, 10).Value = Convert.ToDateTime(TextBox5.Text);
                    cmd.Parameters.Add("@BMI", SqlDbType.Float, 20).Value = Convert.ToDouble(Convert.ToDouble(TextBox2.Text) / Convert.ToDouble(TextBox1.Text) / Convert.ToDouble(TextBox1.Text) * 100 * 100);

                    switch (RadioButtonList1.SelectedValue)
                    {
                        case "男":
                            cmd.Parameters.Add("@basic", SqlDbType.Int, 10).Value = Convert.ToInt32((13.7 * Convert.ToDouble(TextBox1.Text)) + (5.0 * Convert.ToDouble(TextBox2.Text)) - (6.8 * Convert.ToInt32(TextBox4.Text)) + 66);
                            basic = Convert.ToInt32((13.7 * Convert.ToDouble(TextBox1.Text)) + (5.0 * Convert.ToDouble(TextBox2.Text)) - (6.8 * Convert.ToInt32(TextBox4.Text)) + 66);

                            break;
                        case "女":
                            cmd.Parameters.Add("@basic", SqlDbType.Int, 10).Value = Convert.ToInt32((9.6 * Convert.ToDouble(TextBox1.Text)) + (1.8 * Convert.ToDouble(TextBox2.Text)) - (4.7 * Convert.ToInt32(TextBox4.Text)) + 655);
                            basic = Convert.ToInt32((9.6 * Convert.ToDouble(TextBox1.Text)) + (1.8 * Convert.ToDouble(TextBox2.Text)) - (4.7 * Convert.ToInt32(TextBox4.Text)) + 655);

                            break;
                        default:
                            Response.Write("hhh");
                            break;
                    }

                    if (a == 0)
                    {
                        cmd.Parameters.Add("@power", SqlDbType.Int, 10).Value = Convert.ToInt32(basic) - Convert.ToInt32(powerd);
                    }
                    else
                    {
                        cmd.Parameters.Add("@power", SqlDbType.Int, 10).Value = Convert.ToInt32(0);
                    }


                    cmd.ExecuteNonQuery();
                    Response.Write("<script>alert('新增成功')</script>");

                }

            }
            catch (Exception ex)
            {
                Label1.Text = "資料讀取錯誤";
            }
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者頁面.aspx");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class 飲食紀錄 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel2.Visible = false;
        Panel1.Visible = true;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel1.Visible = false;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        bool status = true;
        double s = 0.0;
        if (string.IsNullOrEmpty(TextBox3.Text))
        {
            Label2.Text = "資料填寫不完全";
            status = false;
        }
        else if (string.IsNullOrEmpty(TextBox4.Text))
            status = false;
        else if (!double.TryParse(TextBox4.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox5.Text))
            status = false;
        else if (!double.TryParse(TextBox5.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox6.Text))
            status = false;
        else if (!double.TryParse(TextBox6.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;

        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox8.Text))
            status = false;
        else if (!double.TryParse(TextBox8.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox9.Text))
            status = false;
        else if (!double.TryParse(TextBox9.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox10.Text))
            status = false;
        else if (!double.TryParse(TextBox10.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox11.Text))
            status = false;
        else if (!double.TryParse(TextBox11.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;
        else if (string.IsNullOrEmpty(TextBox14.Text))
            status = false;
        else if (!double.TryParse(TextBox14.Text, out s))
            status = false;
        else if (s < 0.0)
            status = false;

        if (status == true)
        {
            using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
            {
                co.Open();
                SqlCommand cmd = new SqlCommand("Insert into 飲食紀錄(姓名,食物名稱,熱量,蛋白質,脂肪,碳水化合物,膳食纖維,糖,鈣,鈉,時段,日期)values(@name,@foodname,@power,@protain,@f,@totalsuger,@u,@suger,@t, @sault, @time,@day)", co);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 10).Value = Request.QueryString["name"].ToString();
                cmd.Parameters.Add("@foodname", SqlDbType.NVarChar, 10).Value = TextBox3.Text;
                cmd.Parameters.Add("@power", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox4.Text);
                cmd.Parameters.Add("@protain", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox5.Text);

                cmd.Parameters.Add("@f", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox6.Text);

                cmd.Parameters.Add("@suger", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox8.Text);


                cmd.Parameters.Add("@u", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox10.Text);

                cmd.Parameters.Add("@totalsuger", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox9.Text);
                cmd.Parameters.Add("@sault", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox11.Text);
                cmd.Parameters.Add("@t", SqlDbType.Float, 10).Value = Convert.ToDouble(TextBox14.Text);
                cmd.Parameters.Add("@time", SqlDbType.NVarChar, 10).Value = RadioButtonList1.SelectedValue;
                cmd.Parameters.Add("@day", SqlDbType.Date, 10).Value = Convert.ToDateTime(TextBox13.Text);
                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('新增成功')</script>");

            }
        }
        else {
            Response.Write("<script>alert('新增失敗')</script>");
        }
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        bool status = true;
        double s=1.0;
        if (TextBox1.Text=="")
        {
            Label1.Text = "資料填寫不完全";
            status = false;
        }
        else if (string.IsNullOrEmpty(TextBox2.Text))
            status = false;
      
        else if (!double.TryParse(TextBox1.Text, out s))
        {
            status = false;
        }
        else if (s < 0.0)
            status = false;
        if (status == true)
        {
            using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
            {
                co.Open();
                SqlCommand cmd = new SqlCommand("SELECT*from 食物名稱 where 食物名稱='" + DropDownList1.SelectedValue + "'", co);
                SqlDataReader rd = cmd.ExecuteReader();


                using (SqlConnection co1 = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True ;MultipleActiveResultSets=True"))
                {
                    co1.Open();

                    SqlCommand cmd1 = new SqlCommand("Insert into 飲食紀錄(姓名,食物名稱,熱量,蛋白質,脂肪,碳水化合物,膳食纖維,糖,鈉,時段,日期)values(@name,@foodname,@power,@protain,@f,@totalsuger,@u,@suger, @sault, @time,@day)", co);
                    while (rd.Read())
                    {
                        cmd1.Parameters.Add("@name", SqlDbType.NVarChar, 10).Value = Request.QueryString["name"].ToString();
                        cmd1.Parameters.Add("@foodname", SqlDbType.NVarChar, 10).Value = rd["食物名稱"].ToString();
                        cmd1.Parameters.Add("@power", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["熱量"]) * Convert.ToInt32(TextBox1.Text);
                        cmd1.Parameters.Add("@protain", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["蛋白質(g)"]) * Convert.ToInt32(TextBox1.Text);

                        cmd1.Parameters.Add("@f", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["脂肪(g)"]) * Convert.ToInt32(TextBox1.Text);

                        cmd1.Parameters.Add("@suger", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["糖"]) * Convert.ToInt32(TextBox1.Text);


                        cmd1.Parameters.Add("@u", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["膳食纖維"]) * Convert.ToInt32(TextBox1.Text);

                        cmd1.Parameters.Add("@totalsuger", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["碳水化合物"]) * Convert.ToInt32(TextBox1.Text);
                        cmd1.Parameters.Add("@sault", SqlDbType.Float, 10).Value = Convert.ToDouble(rd["納"]) * Convert.ToInt32(TextBox1.Text);

                        cmd1.Parameters.Add("@time", SqlDbType.NVarChar, 10).Value = RadioButtonList1.SelectedValue;
                        cmd1.Parameters.Add("@day", SqlDbType.Date, 10).Value = Convert.ToDateTime(TextBox2.Text);
                    }
                    cmd1.ExecuteNonQuery();
                    Response.Write("<script>alert('新增成功')</script>");
                }
            }
        }
        else {
            Response.Write("<script>alert('新增失敗')</script>");
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者頁面.aspx");
    }
}
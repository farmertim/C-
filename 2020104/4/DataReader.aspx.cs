using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class DataReader : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        n();
    }
    protected void n() {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select 姓名 from 客戶資料", co);

            DataTable dt = new DataTable();
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "button")
        {
            string s = "";
            using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
            {
                try
                {
                    co.Open();
                    SqlCommand cmd = new SqlCommand("Select 食物名稱 from 飲食紀錄 where Id=@id", co);
                    Response.Write(e.CommandArgument);
                    Response.Write(GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text);
                    cmd.Parameters.Add("@id", SqlDbType.Int, 10).Value = Convert.ToInt32(GridView1.Rows[Convert.ToInt32(e.CommandArgument)].Cells[1].Text);
                    SqlDataReader rd = cmd.ExecuteReader();
                    while (rd.Read())
                    {
                        s += rd["食物名稱"].ToString() + "<br/>";
                    }
                    Label1.Text = s;
                }
                catch (Exception es)
                {
                    Response.Write(es);
                }
            }
        }
   }

    protected void Button2_Click(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            try
            {
                co.Open();
                SqlCommand cmd = new SqlCommand("insert into 客戶資料 (姓名,帳號,密碼) values (@name,@account,@password)", co);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 40).Value = TextBox1.Text;
                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 40).Value = TextBox2.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 40).Value = TextBox3.Text;
                cmd.ExecuteNonQuery();
                n();
            }
            catch (Exception es) {
                Response.Write(es);
            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            try
            {
                co.Open();
                SqlCommand cmd = new SqlCommand("Update 客戶資料 set 姓名=@name,帳號=@account,密碼=@password where Id=@id", co);
                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 40).Value = TextBox1.Text;
                cmd.Parameters.Add("@account", SqlDbType.NVarChar, 40).Value = TextBox2.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar, 40).Value = TextBox3.Text;
                cmd.Parameters.Add("@id", SqlDbType.Int, 40).Value =Convert.ToInt32( TextBox4.Text);
                cmd.ExecuteNonQuery();
                n();
            }
            catch (Exception es)
            {
                Response.Write(es);
            }
        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        n();
    }
   
}
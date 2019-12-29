using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class practice2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        b();
        //SqlDataSource ss = new SqlDataSource();
        //ss.ConnectionString = "Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True";
        //ss.SelectCommand = "select*from 客戶資料";
        //ss.DataSourceMode = SqlDataSourceMode.DataSet;
        //DataSourceSelectArguments args = new DataSourceSelectArguments();
        //DataView dv = new DataView();
        //dv = (DataView)ss.Select(args);
        //GridView1.DataSource = dv;
        //GridView1.DataBind();
        //ss.Dispose();
    }

    protected void b() {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True")) {
            co.Open();
            SqlDataAdapter sd = new SqlDataAdapter("Select * from 客戶資料", co);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
      b();
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        b();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlDataSource ds = new SqlDataSource();
        ds.ConnectionString = "Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True";

        int my_id = Convert.ToInt32(GridView1.Rows[e.RowIndex].Cells[3].Text);
        Response.Write("<script>alert('" + my_id+ "')</script>");
        ds.DeleteCommand = "delete from 客戶資料 where Id=@id";
        Response.Write(e.RowIndex);
        ds.DeleteParameters.Add("id", my_id.ToString());
        ds.Delete();
        b();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("update 客戶資料 set 姓名=@name,帳號=@acc,密碼=@pass where Id=@id",co);
            TextBox name = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
            TextBox account = (TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0];
            TextBox password = (TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0];
            TextBox key = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];

            da.UpdateCommand.Parameters.Add("@id",SqlDbType.Int,40).Value= key.Text;
            da.UpdateCommand.Parameters.Add("@name",SqlDbType.NVarChar,40).Value = name.Text.ToString();
            da.UpdateCommand.Parameters.Add("@acc", SqlDbType.NVarChar, 40).Value=account.Text.ToString();
            da.UpdateCommand.Parameters.Add("pass", SqlDbType.NVarChar, 40).Value=password.Text.ToString();
            da.UpdateCommand.ExecuteNonQuery();
        }
       
      
        GridView1.EditIndex = -1;
        b();
     }
}
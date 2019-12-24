using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

public partial class _20191224 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        myDataSource();
    }
    protected void myDataSource() {
        SqlDataSource Datasource1 = new SqlDataSource();
        Datasource1.ConnectionString = "Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True";
        Datasource1.SelectCommand = "select top 10*from 客戶資料";
        Datasource1.DataSourceMode = SqlDataSourceMode.DataReader;
        DataSourceSelectArguments args = new DataSourceSelectArguments();
        GridView1.DataSource = Datasource1.Select(args);
        GridView1.DataBind();
    }

    //刪除
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        SqlDataSource Datasource2 = new SqlDataSource();
        Datasource2.ConnectionString= "Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True";
        Datasource2.DeleteCommand = "delete from 客戶資料 where Id=@id";

        Datasource2.DeleteParameters.Add("id", Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value).ToString());
        //Datasource2.DeleteParameters.Add(new Parameter("id",TypeCode.Int32));
        //Datasource2.DeleteParameters["id"].DefaultValue = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value).ToString();
        Datasource2.Delete();
        myDataSource();
    }
    //編輯的取消


    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        myDataSource();
    }

    //更新
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox name, account, password;
       
        name = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
        account = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
        password = (TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0];
        int check = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
        SqlDataSource sd = new SqlDataSource();
        sd.ConnectionString= "Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True";
        sd.UpdateCommand = "update  客戶資料 set 姓名=@name,帳號=@a,密碼=@p where Id=" + check;
        sd.UpdateParameters.Add("@name", name.Text);
        sd.UpdateParameters.Add("@a", account.Text);
        sd.UpdateParameters.Add("@p", password.Text);
        sd.Update();
        sd.Dispose();

    
        GridView1.EditIndex = -1;
        myDataSource();
    }
    //打開編輯
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        myDataSource();
    }
}
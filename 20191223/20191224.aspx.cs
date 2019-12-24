using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _20191224 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        myDataSource();
    }
    protected void myDataSource() {
        SqlDataSource Datasource1 = new SqlDataSource();
        Datasource1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
        Datasource1.SelectCommand = "select top 10*from Orders";
        Datasource1.DataSourceMode = SqlDataSourceMode.DataReader;
        DataSourceSelectArguments args = new DataSourceSelectArguments();
        GridView1.DataSource = Datasource1.Select(args);
        GridView1.DataBind();
    }

    //刪除
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {

    }
    //編輯的取消


    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {

    }
}
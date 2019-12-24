using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;


public partial class practice3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataSource SqlDataSource1 = new SqlDataSource();
        SqlDataSource1.ConnectionString = WebConfigurationManager.ConnectionStrings["northwndConnectionString"].ConnectionString;
        SqlDataSource1.SelectCommand = "select*from Customers";
        DataSourceSelectArguments args = new DataSourceSelectArguments();

      
        SqlDataSource1.DataSourceMode = SqlDataSourceMode.DataReader;
        GridView1.DataSource = SqlDataSource1.Select(args);
        GridView1.DataBind();
        SqlDataSource1.Dispose();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlDataSource SqlDataSource2 = new SqlDataSource();

            SqlDataSource2.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30";
            SqlDataSource2.InsertCommand = "Insert into Categories(CategoryName) values (@name)";
            SqlDataSource2.InsertParameters.Add("@name", TextBox1.Text);

            int check = SqlDataSource2.Insert();
            if (check == 0)
            {
                Response.Write("<script>新增失敗</script>");
            }
            else
            {
                Response.Write("<script>新增成功</script>");
            }
        }
        catch (Exception es) {
            Response.Write(es);
        }
    }
}
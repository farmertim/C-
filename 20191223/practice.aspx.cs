using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class practice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection co=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from Orders", co);
            SqlDataAdapter da1 = new SqlDataAdapter("select * from [Order Details]", co);
            DataSet ds = new DataSet();
            da1.Fill(ds, "orderdetails");
            da.Fill(ds, "orders");
            ds.Relations.Add("relation", ds.Tables["orders"].Columns["OrderID"], ds.Tables["orderdetails"].Columns["OrderID"]);
            int a = 0;
            foreach (DataRow table in ds.Tables["orders"].Rows){
                foreach(DataRow table1 in table.GetChildRows(ds.Relations["relation"]))
                {
                    a = Convert.ToInt32(table1["OrderID"].ToString());
                  
                    break;
                }
                break;
            }
            GridView1.DataSource = ds;
            GridView1.DataBind();

            SqlDataAdapter d = new SqlDataAdapter("select top 1*from [Order Details] where OrderID="+Convert.ToInt32(a), co);
            SqlDataReader d1 = d.SelectCommand.ExecuteReader();
            GridView2.DataSource = d1;
            GridView2.DataBind();
        }
    }
}
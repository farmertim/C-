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
        //SqlDataSource SqlDataSource1 = new SqlDataSource();
        //SqlDataSource1.ConnectionString = WebConfigurationManager.ConnectionStrings["northwndConnectionString"].ConnectionString;
        //SqlDataSource1.SelectCommand = "select*from Customers";
        //DataSourceSelectArguments args = new DataSourceSelectArguments();


        //SqlDataSource1.DataSourceMode = SqlDataSourceMode.DataReader;
        if (!IsPostBack)
        {
            using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                co.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select * from Products", co);
                SqlDataAdapter ad1 = new SqlDataAdapter("select * from Orders", co);
                SqlDataAdapter ad2 = new SqlDataAdapter("select * from [Order Details]", co);

                DataSet ds = new DataSet();
                ad.Fill(ds, "products");
                ad1.Fill(ds, "orders");
                ad2.Fill(ds, "o");
                DropDownList1.DataSource = ds.Tables["orders"];
                DropDownList1.DataTextField = ds.Tables["orders"].Columns["OrderID"].ToString();
                DropDownList1.DataValueField = ds.Tables["orders"].Columns["OrderID"].ToString();
                DropDownList1.DataBind();

                DropDownList2.DataSource = ds.Tables["products"];
                DropDownList2.DataTextField = ds.Tables["products"].Columns["ProductID"].ToString();
                DropDownList2.DataValueField = ds.Tables["products"].Columns["ProductID"].ToString();
                DropDownList2.DataBind();

                GridView1.DataSource =ds.Tables["o"];

                GridView1.DataBind();

            }
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Response.Write("<script>alert('資料填寫不完全')</script>");
        }
        else if (TextBox2.Text == "")
        {
            Response.Write("<script>alert('資料填寫不完全')</script>");
        }
        else if (TextBox3.Text == "")
            Response.Write("<script>alert('資料填寫不完全')</script>");
        else
        {
            using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                co.Open();

                  SqlDataAdapter ad1 = new SqlDataAdapter(); SqlDataAdapter ad = new SqlDataAdapter("select*from [Order Details] where OrderID=" + Convert.ToInt32(DropDownList1.SelectedValue), co);
                ad1.InsertCommand = new SqlCommand("Insert into [Order Details] (OrderID,ProductID,UnitPrice,Quantity,Discount) values (@id,@pid,@up,@Q,@dt)", co);

                DataSet ds1 = new DataSet();
                ad.Fill(ds1, "order");
              
              
                   ad1.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(DropDownList1.SelectedValue);
                ad1.InsertCommand.Parameters.Add("@pid", SqlDbType.Int).Value = Convert.ToInt32(DropDownList2.SelectedValue);
                ad1.InsertCommand.Parameters.Add("@up", SqlDbType.Money, 10).Value =Convert.ToDouble( TextBox1.Text);
                ad1.InsertCommand.Parameters.Add("@Q", SqlDbType.SmallInt, 10).Value =Convert.ToInt16( TextBox2.Text);
                ad1.InsertCommand.Parameters.Add("@dt", SqlDbType.Real, 10).Value =Convert.ToDouble( TextBox3.Text);
               // ad1.InsertCommand.ExecuteNonQuery();
                ad1.Update(ds1, "order");
               

               
               
                DataRow dr = ds1.Tables["order"].NewRow();
                dr["OrderID"] = DropDownList1.SelectedValue;
                dr["ProductID"] = DropDownList2.SelectedValue;
                dr["UnitPrice"] = TextBox1.Text;
                dr["Quantity"] = TextBox2.Text;
                dr["Discount"] = TextBox3.Text;
                ds1.Tables["order"].Rows.Add(dr);
                
                GridView1.DataSource = ds1.Tables["order"];

                GridView1.DataBind();
            }


        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        int s = Convert.ToInt32(DropDownList2.SelectedValue);
        //where ProductID="+Convert.ToInt32(s)
        using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select UnitPrice from Products where ProductID="+s, co);
            DataSet ds = new DataSet();
            ad.Fill(ds, "products");
            TextBox1.Text = ds.Tables["products"].Rows[0]["UnitPrice"].ToString();
            //DataTable da = new DataTable();
            //ad.Fill(da);
         



        }
    }

    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;

    }
}
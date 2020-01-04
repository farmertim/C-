using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

public partial class practice2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            u();
        }
    }

    protected void u() {
        using (SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mount\OneDrive\文件\MS_SQL_2015\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Orders", co);
            SqlDataAdapter da1 = new SqlDataAdapter("select * from Products", co);
            DataSet ds = new DataSet();
            da.Fill(ds, "orders");
            da1.Fill(ds, "products");
            DropDownList1.DataSource = ds.Tables["orders"];
            DropDownList1.DataTextField = ds.Tables["orders"].Columns["OrderID"].ToString();
            DropDownList1.DataValueField = ds.Tables["orders"].Columns["OrderID"].ToString();
            DropDownList1.DataBind();

            DropDownList2.DataSource = ds.Tables["products"];
            DropDownList2.DataValueField = ds.Tables["products"].Columns["ProductID"].ToString();
            DropDownList2.DataTextField = ds.Tables["products"].Columns["ProductID"].ToString();
            DropDownList2.DataBind();
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mount\OneDrive\文件\MS_SQL_2015\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("select UnitPrice from Products where ProductID="+DropDownList2.SelectedValue, co);
            DataTable td = new DataTable();
            da.Fill(td);
            TextBox1.Text =td.Rows[0]["UnitPrice"].ToString() ;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mount\OneDrive\文件\MS_SQL_2015\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from [Order Details] where OrderID="+DropDownList1.SelectedValue, co);
            //SqlDataAdapter da1 = new SqlDataAdapter("INsert into [Order Details] (OrderID,ProductID,UnitPrice,Quantity,Discount) values (@id,@id1,@price,@q,@d) ", co);
            
            DataSet ds = new DataSet();
            da.Fill(ds, "products");
            //da1.Fill(ds, "p");
            DataTable t = new DataTable();
            t = ds.Tables["products"];
            //DataTable t1 = new DataTable();
            //t1 = ds.Tables["p"];
            DataRow d = t.NewRow();
            d["OrderID"] = DropDownList1.SelectedValue;
            d["ProductID"] = DropDownList2.SelectedValue;
            d["UnitPrice"] = TextBox1.Text;
            d["Quantity"] = TextBox2.Text;
            d["Discount"] =TextBox3.Text;
            t.Rows.Add(d);
            //da.Update(t);
            GridView1.DataSource = t;
            GridView1.DataBind();
        }
    }
}
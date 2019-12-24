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
        using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30")) {
            co.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select distinct Discontinued from Products", co);
            SqlDataAdapter ad1 = new SqlDataAdapter("select *from Suppliers", co);
            DataSet ds = new DataSet();
            ad.Fill(ds, "products");
            ad1.Fill(ds, "suppliers");
          
       
            DropDownList1.DataSource = ds.Tables["suppliers"];
            DropDownList1.DataTextField = ds.Tables["Suppliers"].Columns["CompanyName"].ToString();
            DropDownList1.DataValueField = ds.Tables["Suppliers"].Columns["SupplierID"].ToString();
            DropDownList1.DataBind();
            RadioButtonList1.DataSource = ds.Tables["products"];
            RadioButtonList1.DataTextField = ds.Tables["products"].Columns["Discontinued"].ToString();

            RadioButtonList1.DataBind();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30")) {
            co.Open();
            SqlDataAdapter ad = new SqlDataAdapter();
            try
            {
                ad.InsertCommand = new SqlCommand("Insert into Products (ProductName,UnitPrice,Discontinued) values(@com,@id,@dis)", co);
                ad.InsertCommand.Parameters.Add("@com", SqlDbType.NVarChar, 40).Value =TextBox1.Text;
                ad.InsertCommand.Parameters.Add("@id", SqlDbType.Money, 10).Value = 999;
                ad.InsertCommand.Parameters.Add("@dis", SqlDbType.Bit, 10).Value =0;
                int row = ad.InsertCommand.ExecuteNonQuery();
                Response.Write(row.ToString());
            }catch(Exception es)
            {
                Response.Write(es);
            }
        }
        
      }
}
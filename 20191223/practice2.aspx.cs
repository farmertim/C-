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
        if (!IsPostBack)
        {
            using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                co.Open();
                SqlDataAdapter ad = new SqlDataAdapter("select * from Products", co);

                DataSet ds = new DataSet();
                ad.Fill(ds, "products");
                DropDownList1.DataSource = ds.Tables["products"];
                DropDownList1.DataTextField = ds.Tables["products"].Columns["ProductName"].ToString();
                DropDownList1.DataValueField = ds.Tables["products"].Columns["ProductID"].ToString();
                DropDownList1.DataBind();



            }
        }
    }

   

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int s =Convert.ToInt32( DropDownList1.SelectedValue);
        //where ProductID="+Convert.ToInt32(s)
        using (SqlConnection co = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\MS_SQL_2012\\northwnd.mdf;Integrated Security=True;Connect Timeout=30"))
        {
            co.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select*from Products ",co);
            DataSet ds = new DataSet();
            ad.Fill(ds, "products");
            //DataTable da = new DataTable();
            //ad.Fill(da);
            DataRow[] rows = ds.Tables["Products"].Select("ProductID="+s);
            DetailsView1.DataSource = rows.CopyToDataTable();
            DetailsView1.DataBind();


           
        }
    }

    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        DetailsView1.PageIndex = e.NewPageIndex;

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

public partial class newpractice : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            co.Open();
            SqlDataAdapter ad = new SqlDataAdapter("select*from 運動紀錄 ", co);
            DataSet st = new DataSet();
            ad.Fill(st, "new");

            //DataRow[] row = st.Tables["new"].Select("姓名='胡維仁'");
            //GridView1.DataSource = row.CopyToDataTable();
            GridView1.DataSource = st;
            GridView1.DataBind();
        }
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            co.Open();
            SqlDataAdapter myadapter = null;
            myadapter = new SqlDataAdapter("SELECT Id,姓名 from 運動紀錄", co);
            DataSet ds = new DataSet();
            myadapter.Fill(ds, "name");
            DataTable mytabel = ds.Tables["name"];
            string str;
            str = "<table border=1><tr><td>Id</td><td>name</td></tr>";
            for (int i = 0; i < mytabel.Rows.Count; i++)
            {
                str = str + "<tr>";
                str = str + "<td>" + mytabel.Rows[i]["Id"] + "</td>";
                str = str + "<td>" + mytabel.Rows[i]["姓名"] + "</td>";
                str = str + "</tr>";
            }

            str = str + "</table>";
            Label1.Text = str;
        }
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            co.Open();
            
            SqlDataAdapter myadapter = new SqlDataAdapter("SELECT Id,姓名 from 運動紀錄", co);
            DataSet ds = new DataSet();
            myadapter.Fill(ds, "name1");

            DataView dv = new DataView(ds.Tables["name1"],"Id>='2'","姓名",DataViewRowState.CurrentRows);
            GridView2.DataSource = dv;
            GridView2.DataBind();

        }
    }

}
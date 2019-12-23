using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


public partial class 資料繫結 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable dt = getName();
        DropDownList1.DataSource = dt;
        DropDownList1.DataTextField = dt.Columns["姓名"].ToString();
        DropDownList1.DataBind();

        CheckBoxList1.DataSource = dt;
        CheckBoxList1.DataTextField = dt.Columns["帳號"].ToString();
        CheckBoxList1.DataBind();
    }
    protected DataTable getName() {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True")) {

            SqlDataAdapter da = new SqlDataAdapter("Select * from 客戶資料",co);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
    }
}
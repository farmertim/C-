using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
//*********************************自己加寫（宣告）的NameSpace
using System.Web.Configuration;
using System.Data.SqlClient;



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
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected DataTable getName()
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {

            SqlDataAdapter da = new SqlDataAdapter("Select * from 客戶資料", co);
            DataTable dt = new DataTable();
            
            da.Fill(dt);

            return dt;
        }

    }

    protected void db()
    {
        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            SqlDataAdapter da = new SqlDataAdapter("Select*from 客戶資料", co);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds, "cumstomer");
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            catch (Exception e) {

            }
        }
    }

    protected void RowEditeing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        db();
    }



    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        TextBox name, account, password,Id;
        name = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
        account = (TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0];
        password = (TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0];
        Id = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];

        using (SqlConnection co = new SqlConnection("Data Source=LAPTOP-Q9A6IMGN\\SQLEXPRESS;Initial Catalog=運動與飲食紀錄;Integrated Security=True"))
        {
            co.Open();
            //SqlDataAdapter da = new SqlDataAdapter();
            //da.UpdateCommand = new SqlCommand("UPdate 客戶資料 set 姓名=@name ,帳號=@account,密碼=@password where Id=@id", co);
            //da.UpdateCommand.Parameters.Add("@name", SqlDbType.NVarChar, 10).Value = name.Text;
            //da.UpdateCommand.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = account.Text;
            //da.UpdateCommand.Parameters.Add("@password", SqlDbType.NVarChar, 10).Value = password.Text;
            //da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10).Value = Convert.ToInt32(Id.Text);

            SqlDataAdapter da = new SqlDataAdapter("UPdate 客戶資料 set 姓名=@name ,帳號=@account,密碼=@password where Id=@id", co);
            da.UpdateCommand.Parameters.Add("@name", SqlDbType.NVarChar, 10).Value = name.Text;
            da.UpdateCommand.Parameters.Add("@account", SqlDbType.NVarChar, 10).Value = account.Text;
            da.UpdateCommand.Parameters.Add("@password", SqlDbType.NVarChar, 10).Value = password.Text;
            da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int, 10).Value = Convert.ToInt32(Id.Text);
            da.UpdateCommand.ExecuteNonQuery();
            db();
            GridView1.EditIndex = -1;
        }
    }

    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        db();
    }
}
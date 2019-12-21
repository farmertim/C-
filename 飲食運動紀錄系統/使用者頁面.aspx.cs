using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class 使用者頁面 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            string str = Request.QueryString["姓名"];
            Label3.Text = str;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            switch (DropDownList1.SelectedValue)
            {
                case "運動紀錄":
                    Label2.Text = DropDownList1.SelectedValue;
                    Panel3.Visible = false;
                    Panel1.Visible = true;
                    Panel4.Visible = false;
                    break;
                case "飲食紀錄":
                    Label2.Text = DropDownList1.SelectedValue;
                    Panel1.Visible = false;
                    Panel3.Visible = true;
                    Panel4.Visible = false;
                    break;
                case "身體狀況紀錄":
                    Label2.Text = DropDownList1.SelectedValue;
                    Panel1.Visible = false;
                    Panel3.Visible = false;
                    Panel4.Visible = true;
                    break;
            }
        }catch(Exception es)
        {

        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["姓名"] != null)
            {
                Response.Redirect("新增運動內容.aspx?name=" + Session["姓名"].ToString());
            }
            else
            {
                Response.Write("<script>alert('no')</script>");
            }
        }catch(Exception es)
        {
            
        }
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["姓名"] != null)
            {
                Response.Redirect("查詢運動紀錄.aspx?姓名=" + Session["姓名"].ToString());
            }
            else
            {
                Response.Write("<script>alert('no')</script>");
            }
        }catch(Exception es)
        {

        }
    }

    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["姓名"] != null)
            {
                Response.Redirect("飲食紀錄.aspx?name=" + Session["姓名"].ToString());
            }
            else
            {
                Response.Write("<script>alert('no')</script>");
            }
        }
        catch (Exception es) {
        }
    }

    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["姓名"] != null)
            {
                Response.Redirect("查詢飲食紀錄.aspx?姓名=" + Session["姓名"].ToString());
            }
            else
            {
                Response.Write("<script>alert('no')</script>");
            }
        }catch(Exception es)
        {

        }
    }

    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("使用者登陸.aspx");
    }

    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["姓名"] != null)
            {
                Response.Redirect("體態紀錄.aspx?姓名=" + Session["姓名"].ToString());
            }
            else
            {
                Response.Write("<script>alert('no')</script>");
            }
        }catch(Exception es)
        {

        }
    }

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (Session["姓名"] != null)
            {

                Response.Redirect("查詢體態紀錄.aspx?姓名=" + Session["姓名"].ToString());
            }
            else
            {
                Response.Write("<script>alert('no')</script>");
            }
        }catch(Exception es)
        {

        }
    }
}
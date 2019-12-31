using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;


public partial class 檔案上傳 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = @"C:\Users\mount\OneDrive\文件\GitHub\C-\20191231\";
        Boolean filecheck = false;
        if (FileUpload1.HasFile)
        {

            int check = FileUpload1.PostedFile.ContentLength;
            if (check < 500000)//檔案大小0.5MB
            {
                string filename = s + FileUpload1.FileName;
                string fileExtension = System.IO.Path.GetExtension(filename).ToLower();
                string[] allow = { ".jpg", ".pdf" };//格式
                for (int i = 0; i < allow.Length; i++)//字串比較
                {
                    if (allow[i] ==fileExtension)
                    {
                        Response.Write("<script>alert('OK')</script>");
                        FileUpload1.SaveAs(filename);
                        Response.Write("<script>alert('" + filename + "')</script>");
                        string d="~/"+FileUpload1.FileName;
                        Image1.ImageUrl = d;
                    }
                    if (i == allow.Length)
                    {
                        Response.Write("<script>alert('格式不符合')</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('so big')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('NO')</script>");
        }
      
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string save="",save1;
        using (StreamReader dr = new StreamReader(@"D:\網二\讀檔.txt"))//讀檔出來
        {
            do
            {
                save += dr.ReadLine();
                save1 = dr.ReadLine();
            } while (save1!= null);
            dr.Close();
        }
        //using (StreamWriter sw = new StreamWriter(@"D:\網二\讀檔.txt"))//剛剛讀的檔加上新的文字檔
        //{

        //        //.ToShortDateString()   
        //        sw.Write(save+"<br/>"+TextBox1.Text);
        //    sw.WriteLine(DateTime.Now);
        //    sw.Close();
        //    Response.Write("<script>alert('新增成功')</script>");
        //    TextBox1.Text = "";
        //}

        using (StreamWriter sw = File.AppendText(@"D:\網二\讀檔.txt")) {//File.AppendText附加在檔案末端
            sw.Write(TextBox1.Text + "<br/>");
            sw.WriteLine(DateTime.Now);
                sw.Close();
                Response.Write("<script>alert('新增成功')</script>");
                TextBox1.Text = "";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        using (StreamReader sr = new StreamReader(@"D:\網二\讀檔.txt")) {
            string check,read="";
            do {
                read += sr.ReadLine();
                check = sr.ReadLine();
            }while(check!=null);
            sr.Close();
            Label1.Text = read;
        }
    }

    protected void Button4_Click(object sender, EventArgs e)//新增資夾的檔案
    {
        if (File.Exists(TextBox2.Text) )
        {
            Response.Write("<script>alert('檔案已存在')</script>");
        }
        else
        {
            string s;
            FileInfo fi = new FileInfo(TextBox2.Text);
            fi.Create();
            s= "檔案在" + fi.CreationTime.ToShortDateString() + fi.CreationTime.ToShortTimeString() + "建立";
            Response.Write("<script>alert('"+s+"')</script>");
        
        }
        // FileInfo fi = new FileInfo(@"D:\網二\讀檔1.txt");
        //FileInfo fi1 = new FileInfo(@"D:\網二\讀檔2.txt");

       // fi.Create();
        //fi1.Create();
    }

    
}
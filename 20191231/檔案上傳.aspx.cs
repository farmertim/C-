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
        string save = "";
        string save1 = "";
        using (StreamReader dr = new StreamReader(@"C:\Users\mount\OneDrive\文件\GitHub\C-\20191231\123.txt"))//讀檔出來
        {

            do
            {
                save += dr.ReadLine();
                save1 = dr.ReadLine();
            } while (save1 != null);
            dr.Close();
        }

        FileUpload1.Visible = false;
        Button1.Visible = false;
        
        // Image1.ImageUrl = @"D:\網二\Ball.jpg";
        //string filename = Server.MapPath("./D:網二/終點.jpg") ;
        //Image1.ImageUrl = filename;
        if (!IsPostBack)
        {
            Image1.ImageUrl = "~/"+save;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = @"C:\Users\mount\OneDrive\文件\GitHub\C-\20191231\";
        // string s = @"D:\網二\";

        if (FileUpload1.HasFile)
        {

            int check = FileUpload1.PostedFile.ContentLength;
            if (check < 5000000)//檔案大小5MB
            {
                string filename = s + FileUpload1.FileName;
             
                string fileExtension = Path.GetExtension(filename).ToLower();//傳回指定字串的附檔名
                string[] allow = { ".jpg", ".pdf", ".pptx", ".zip" };//格式
                for (int i = 0; i < allow.Length; i++)//字串比較
                {
                    if (allow[i] == fileExtension)
                    {
                        //Response.Write("<script>alert('OK')</script>");

                        FileUpload1.SaveAs(filename);

                        // Response.Write("<script>alert('" + filename + "')</script>");

                        string save1 = "";
                        string save = "";
                        using (StreamWriter sw = new StreamWriter(@"C:\Users\mount\OneDrive\文件\GitHub\C-\20191231\123.txt"))
                        {
                            sw.Write(FileUpload1.FileName);

                            sw.Close();
                        }
                        using (StreamReader dr = new StreamReader(@"C:\Users\mount\OneDrive\文件\GitHub\C-\20191231\123.txt"))//讀檔出來
                        {
                            do
                            {
                                save += dr.ReadLine();
                                save1 = dr.ReadLine();
                            } while (save1 != null);
                            dr.Close();
                        }
                        string d = "~/" + save;
                        // Response.Write(d);
                        //Image1.ImageUrl = filename;
                        Image1.ImageUrl = d;
                    }
            }

        }
        else
        {
            //Response.Write("<script>alert('so big')</script>");
        }
            FileUpload1.Visible = false;
            Button1.Visible = false;
            Button2.Visible = true;
        }
        else
        {
            Response.Write("<script>alert('無資料')</script>");
            FileUpload1.Visible = false;
            Button1.Visible = false;
            Button2.Visible = true;
        }


    }

    //protected void Button2_Click(object sender, EventArgs e)
    //{
    //    string save="",save1;
    //    using (StreamReader dr = new StreamReader(@"D:\網二\讀檔.txt"))//讀檔出來
    //    {
    //        do
    //        {
    //            save += dr.ReadLine();
    //            save1 = dr.ReadLine();
    //        } while (save1!= null);
    //        dr.Close();
    //    }
    //    //using (StreamWriter sw = new StreamWriter(@"D:\網二\讀檔.txt"))//剛剛讀的檔加上新的文字檔
    //    //{

    //    //        //.ToShortDateString()   
    //    //        sw.Write(save+"<br/>"+TextBox1.Text);
    //    //    sw.WriteLine(DateTime.Now);
    //    //    sw.Close();
    //    //    Response.Write("<script>alert('新增成功')</script>");
    //    //    TextBox1.Text = "";
    //    //}

    //    using (StreamWriter sw = File.AppendText(@"D:\網二\讀檔.txt")) {//File.AppendText附加在檔案末端，用AppendText檔案必須存在
    //        sw.Write(TextBox1.Text );
    //        sw.WriteLine(DateTime.Now);
    //        sw.Flush();
    //            sw.Close();
    //            Response.Write("<script>alert('新增成功')</script>");
    //            TextBox1.Text = "";
    //    }
    //}

    //protected void Button3_Click(object sender, EventArgs e)
    //{
    //    using (StreamReader sr = new StreamReader(@"D:\網二\讀檔.txt")) {
    //        string check,read="";
    //        do {
    //            read += sr.ReadLine();
    //            check = sr.ReadLine();
    //        }while(check!=null);
    //        sr.Close();
    //        Label1.Text = read;
    //    }
    //}

    //protected void Button4_Click(object sender, EventArgs e)//新增資夾的檔案
    //{
    //    if (File.Exists(TextBox2.Text) )
    //    {
    //        FileInfo fi = new FileInfo(TextBox2.Text);
    //        fi.Delete();
    //        Response.Write("<script>alert('檔案已存在')</script>");
    //    }
    //    else
    //    {
    //        string s;
    //        FileInfo fi = new FileInfo(TextBox2.Text);
    //        fi.Create();
    //        s= "檔案在" + fi.CreationTime.ToShortDateString() + fi.CreationTime.ToShortTimeString() + "建立";
    //        Response.Write("<script>alert('"+s+"')</script>");

    //    }
    //    // FileInfo fi = new FileInfo(@"D:\網二\讀檔1.txt");
    //    //FileInfo fi1 = new FileInfo(@"D:\網二\讀檔2.txt");

    //   // fi.Create();
    //    //fi1.Create();
    //}



    //protected void Button5_Click(object sender, EventArgs e)
    //{
    //    if (File.Exists(TextBox2.Text))
    //    {
    //        FileInfo fi = new FileInfo(TextBox2.Text);
    //        fi.Delete();
    //        Response.Write("<script>alert('檔案已刪除')</script>");
    //    }

    //}

    protected void Button2_Click(object sender, EventArgs e)
{
    FileUpload1.Visible = true;
    Button1.Visible = true;
    Button2.Visible = false;
}
}
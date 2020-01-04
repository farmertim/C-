using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class 上傳大頭貼 : System.Web.UI.Page
{
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack) {
               Image1.ImageUrl = "~/" + s;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
       
        string web = Request.PhysicalApplicationPath+"\\";
        string file = FileUpload1.FileName;
        FileUpload1.SaveAs(web + file);
        if (File.Exists(web + "\\abc.txt")) {
            Response.Write("file 已存在");

            FileStream fs = new FileStream(web + "\\abc.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("abcdefg");
            sw.Write(FileUpload1.FileName);

            sw.Flush();
            fs.Close();
            fs.Dispose();
        }
        else {
            StreamWriter sw = File.CreateText(web + "\\abc.txt");
            sw.Write(FileUpload1.FileName);
            sw.Flush();
        }
        /*
        using (StreamWriter sw = File.AppendText(web + "\\下載.txt")) {
            sw.Write(FileUpload1.FileName);
            sw.Flush();
        }
        */
        /*
        using (StreamReader sr = new StreamReader(web + "\\下載.txt")) {
            s = sr.ReadLine();
            Response.Write(s);
            sr.Close();
            sr.Dispose();
        }
        */
    }
}
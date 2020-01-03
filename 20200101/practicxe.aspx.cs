using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Data;


public partial class practicxe : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string savePath = Server.MapPath("~/name.txt");
        Response.Write("server.Mapath  " + savePath);
        string s;
        string saveDir = @"\";
        string ds = Request.PhysicalApplicationPath;
        string sa = saveDir;
        using (StreamReader sd = new StreamReader(ds + sa + "name.txt")) {
            s = sd.ReadLine();
            Response.Write("111111111111111111");
        }
        Response.Write(s);
        Image1.ImageUrl = "~/"+s;
            DirectoryInfo dir = new DirectoryInfo(@"D:\");
      
        FileInfo[] arrey = dir.GetFiles();
        Response.Write(arrey[0].DirectoryName);

        Response.Write(dir.Name+"<br/>");
        foreach (FileInfo fi in arrey) {
            Response.Write(fi.DirectoryName);
            Response.Write("檔案" + fi.Name);
            Response.Write("檔案大小" + fi.Length+ "<br/>");
         

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DirectoryInfo dir1 = new DirectoryInfo(@"D:\mydata");
        dir1.Create();
        Image1.ImageUrl = "~/Ball.jpg";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string saveDir = @"\";
        string ds = Request.PhysicalApplicationPath;
        string sa = saveDir;
        saveDir = ds + saveDir+FileUpload1.FileName;
        Response.Write(saveDir);

        FileUpload1.SaveAs(saveDir);


        using (StreamWriter sw = new StreamWriter(ds+sa+"name.txt"))
        {
            Response.Write(FileUpload1.FileName);
            sw.Write(FileUpload1.FileName);
            sw.Close();
        }
        update();
    }
    protected void update()
    {
        string savePath = Server.MapPath("~/name.txt");
        Response.Write("server.Mapath  " + savePath);
        string s;
        string saveDir = @"\";
        string ds = Request.PhysicalApplicationPath;
        string sa = saveDir;
        using (StreamReader sd = new StreamReader(ds + sa + "name.txt"))
        {
            s = sd.ReadLine();
            Response.Write("111111111111111111");
        }
        Response.Write(s);
        Image1.ImageUrl = "~/" + s;
        DirectoryInfo dir = new DirectoryInfo(@"D:\");

        FileInfo[] arrey = dir.GetFiles();
        Response.Write(arrey[0].DirectoryName);

        Response.Write(dir.Name + "<br/>");
        foreach (FileInfo fi in arrey)
        {
            Response.Write(fi.DirectoryName);
            Response.Write("檔案" + fi.Name);
            Response.Write("檔案大小" + fi.Length + "<br/>");


        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (File.Exists(@"D:\網二\name1.txt"))
        {
            Response.Write("file 已存在");
        }
        else
        {
            FileInfo fi = new FileInfo(@"D:\網二\name1.txt");
            fi.Create();
        }

    }
}
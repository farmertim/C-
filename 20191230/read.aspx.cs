using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using System.Drawing;
using System.Drawing.Imaging;




public partial class read : System.Web.UI.Page
{
    private const string FILE_NAME = "C:\\Users\\mount\\Downloads\\新增資料夾\\新文字文件.txt";

    protected void Page_Load(object sender, EventArgs e)
    {

        using (StreamReader sr = new StreamReader("C:\\Users\\mount\\OneDrive\\桌面\\新增資料夾\\新文字文件.txt"))
        {
            string my_line,p="";
            int count = 0;

            do  //註解： do...while迴圈
            {    //先執行第一次，然後依照 while的條件，看看要不繼續做下去？
                my_line = sr.ReadLine();        //--註解：一次讀取一行。
                Response.Write("<font color=red>" + my_line + "</font><br>");
                if (count == 0)
                {
                    p = my_line;
                    count++;
                }
                else {
                    p += my_line;
                }
            } while (my_line != null);
            Response.Write("<font color=red>" + p + "</font><br>");
            Image1.ImageUrl = p;
            sr.Close();
        }
        //BinaryReader 將基本資料型別以Binary方式讀取
        //BinaryWriter 以Binary方式將基本資料型別寫入資料串流
        //Directory 以靜態方式建立，搬移，顯示資料
        //DirectoryInfo 物件實體方式建立，搬移，顯示資料

        //  Image1.ImageUrl = my.Substring(my.Length - (my.Length - 1));
        //if (FileUpload1.PostedFile != null) {
        //    HttpPostedFile myfile = FileUpload1.PostedFile;
        //    int nFileLen = myfile.ContentLength;
        //    byte[] myData = new byte[nFileLen];

        //}


        //using (Stream file = new FileStream(@"C:\Users\mount\Downloads\\下載.jpg",FileMode.Open)) {
        //    byte[] b = new byte[file.Length];
        //    file.Read(b, 0, (int)file.Length);
        //    var fileSream=new FileStream()
        //}

    }

    protected void Button1_Click(object sender, EventArgs e)
    {


        //FileInfo file1 = new FileInfo("C:\\Users\\mount\\OneDrive\\桌面\\新增資料夾");
        //StreamWriter sw = file1.AppendText();
        //sw.Write(TextBox1.Text);
        //sw.Flush();
        //sw.Close();
        //DirectoryInfo m = new DirectoryInfo("D://");
        //FileStream fs;
        //    //--註解：讀取資料---------------------------------
        //    fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read);
        //    BinaryReader br = new BinaryReader(fs);
        //    Response.Write("<font color=red>C:\\MIS2000Lab_TestFile3.txt 檔案的內容----<br>");
        //    for (int j = 0; j < 10; j++)
        //    {
        //    s += br.Read();
        //        Response.Write(br.Read() + "<br>");
        //    }
        //    Response.Write("</font>");
        //    br.Close();
        //    fs.Close();

        //    fs.Dispose();
        //--程式的最後，請確定對所有 FileStream物件呼叫 .Dispose()方法，尤其是在磁碟空間有限的環境中更應如此。
        //--如果沒有可用的磁碟空間，且在 FileStream完成之前沒有呼叫 .Dispose()方法，則執行 IO作業可能會引發例外狀況。


        DirectoryInfo di = new DirectoryInfo(@"C:\Users\mount\Downloads"); //設定要找的資料夾路徑 
                FileInfo[] fi = di.GetFiles("sea.jpg"); //設定要找的圖片副檔名 
                foreach (FileInfo file in fi)
                      {
            Response.Write(file.Name);
                          //顯示找到的檔案名稱 
                      }
        Image2.ImageUrl = "~\\Users\\mount\\Downloads\\sea.jpg";
              }
}



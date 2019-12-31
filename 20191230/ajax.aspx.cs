using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ajax : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) {
            Session["my_name"] = "321";
            List_All();
            //====第一次進到聊天室，會立刻出現目前所有人的談話內容
            //因為這功能很常用到，所以寫成一個 Function重複呼叫（放在程式的最後）。

            Application.Lock();    //====歡迎新夥伴加入====

            StringBuilder my_Label = new StringBuilder();
            for (int i = 15; i > 0; i--)
            {
                Application["A" + i] = (string)Application["A" + (i - 1)];
                my_Label.Append(Application["A" + i]);
            }
            //==== 上面這段 for迴圈，是聊天室程式裡面的重點！ ====
            //  每當有人發表一則留言，原本畫面上的留言，就會向上推擠。
            //  最新的留言，總會出現在畫面下方的最後一筆。
            //  為了良好的效率，這裡我們改用 StringBuilder來處理字串。

            Application["A1"] = (string)(Session["my_name"] + "  " + DateTime.Now.ToLongTimeString() + "  說： <b>====Hello~ Everybody~ 歡迎新夥伴加入！！====</b><br />");
            my_Label.Append(Application["A1"]);
            Label1.Text = my_Label.ToString();
            Application.UnLock();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Application.Lock();
        StringBuilder my_Label = new StringBuilder();
        for (int i = 15; i > 0; i--)
        {
            Application["A" + i] = (string)Application["A" + (i - 1)];
            my_Label.Append(Application["A" + i]);
        }
        Application["A1"] = ("<font color=" + Session["my_color"] + ">" + Session["my_name"] + "  " + DateTime.Now.ToLongTimeString() + "  說： " + TextBox1.Text + "</font><br />");
        my_Label.Append(Application["A1"]);
        Label1.Text = my_Label.ToString();
        Application.UnLock();
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        List_All();    //====專為AJAX功能撰寫的程式====

        Label2.Text = System.DateTime.Now.ToLongTimeString();
    }
    protected void List_All()
    {   //====列出「目前」聊天室的所有談話內容====
        StringBuilder chatroom = new StringBuilder();
        for (int i = 15; i > 0; i--)
        {
            chatroom.Append((string)Application["A" + i]);
        }
        
        Label1.Text = chatroom.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }
}
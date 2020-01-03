<%@ Page Language="C#" AutoEventWireup="true" CodeFile="practice.aspx.cs" Inherits="practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Image ID="Image1" runat="server" Height="65px" ImageUrl="~/下載 (1).jpg" Width="496px" />
        <br />
        <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                 <asp:Timer ID="Timer1" runat="server" Interval="1000">
                 </asp:Timer>
                 <br />
        現在時間:<%= DateTime.Now.ToLongTimeString() %>
               
      
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br />
        歡迎光臨<br />
        <br />
                姓名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
<br />
                電話:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                用餐時間:<asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem>星期一</asp:ListItem>
            <asp:ListItem>星期二</asp:ListItem>
            <asp:ListItem>星期</asp:ListItem>
            <asp:ListItem>星期四</asp:ListItem>
            <asp:ListItem>星期五</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem>10時</asp:ListItem>
            <asp:ListItem>11時</asp:ListItem>
            <asp:ListItem>12時</asp:ListItem>
        </asp:DropDownList>
        <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="定位" />
                <br />
        <br />
       
        <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                現在時間:<%= DateTime.Now.ToLongTimeString() %>
                <br />
                <br />
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>套餐:<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>三明治</asp:ListItem>
            <asp:ListItem>漢堡</asp:ListItem>
        </asp:DropDownList>
&nbsp; 飲料:<asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>汽水</asp:ListItem>
            <asp:ListItem>可樂</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="訂餐" />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                現在時間:<%= DateTime.Now.ToLongTimeString() %><br /><br /><asp:Label ID="Label6" runat="server"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
    
    </div>
    </form>
</body>
</html>

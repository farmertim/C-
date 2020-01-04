<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updatePanel.aspx.cs" Inherits="updatePanel" %>

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
        <asp:Image ID="Image1" runat="server" Height="228px" ImageUrl="~/IMG_0617.jpg" Width="312px" />
        <br />
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="1000">
                </asp:Timer>
                現在時間:<%= DateTime.Now.ToLongTimeString() %><br />
            </ContentTemplate>
        </asp:UpdatePanel>
        姓名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="確認" OnClick="Button1_Click" />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                
                現在時間:<%= DateTime.Now.ToLongTimeString() %><br /><asp:Label ID="Label1" runat="server"></asp:Label>
            </ContentTemplate>
            
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>
            
        </asp:UpdatePanel>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Session.aspx.cs" Inherits="Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        account:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        password:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="確定" />
        <asp:Button ID="Button2" runat="server" Text="清除" />
    
    </div>
    </form>
</body>
</html>

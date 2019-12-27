<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cookies目的.aspx.cs" Inherits="Cookies目的" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Grade:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="登出" />
    
    </div>
    </form>
</body>
</html>

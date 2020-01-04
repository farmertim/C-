<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Sessionserver.aspx.cs" Inherits="Sessionserver" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        phone:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        adderss:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="修改資料" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="LOgout" />
    
    </div>
    </form>
</body>
</html>

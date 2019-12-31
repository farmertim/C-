<%@ Page Language="C#" AutoEventWireup="true" CodeFile="read.aspx.cs" Inherits="read" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
       
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" />
    
        <br />
        <br />
        <asp:Image ID="Image2" runat="server" />
    
    </div>
    </form>
</body>
</html>

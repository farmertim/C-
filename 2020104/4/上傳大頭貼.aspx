<%@ Page Language="C#" AutoEventWireup="true" CodeFile="上傳大頭貼.aspx.cs" Inherits="上傳大頭貼" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <br />
        <asp:Image ID="Image1" runat="server" />
        <br />
    
    </div>
    </form>
</body>
</html>

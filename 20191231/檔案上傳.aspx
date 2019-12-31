<%@ Page Language="C#" AutoEventWireup="true" CodeFile="檔案上傳.aspx.cs" Inherits="檔案上傳" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" Height="158px" Width="197px" />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="更新大頭貼" />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送出" />
        <br />
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>

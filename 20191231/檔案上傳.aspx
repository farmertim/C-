<%@ Page Language="C#" AutoEventWireup="true" CodeFile="檔案上傳.aspx.cs" Inherits="檔案上傳" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送出" />
        <br />
        <br />
        寫入檔案:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="送出" />
        <br />
        <br />
        讀檔:<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="height: 27px" Text="Button" />
        <br />
        建立新檔(@&quot;D:\網二\讀檔.txt&quot;)位置:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="建立" />
        <br />
        
        
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" />
    </div>
    </form>
</body>
</html>

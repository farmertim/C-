﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="practice2.aspx.cs" Inherits="practice2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        ProductName:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
        </asp:RadioButtonList>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送出" />
    
    </div>
    </form>
</body>
</html>

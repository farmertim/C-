<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Forget.aspx.cs" Inherits="Forget" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .page{
            width:1000px;
            margin-left:auto;
            margin-right:auto;
            text-align:center;
        }
        .ta{
            width:80px;
            margin-left:auto;
            margin-right:auto;
            text-align:center;
        }
        .auto-style1 {
            width: 425px;
            margin-left: auto;
            margin-right: auto;
            text-align:center;
        }
        .auto-style2 {
            width: 351px;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">
                <br />
                <div style="text-align:right">
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="25px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="47px" /></div>
                依帳號做修改:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
                新&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 密&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 碼:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                確&nbsp;&nbsp; 認&nbsp;&nbsp; 密&nbsp;&nbsp; 碼:<asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Height="45px" OnClick="Button1_Click" Text="修改" Width="105px" />
            </td>
        </tr>
    </table>
        <br />
    </div>
    </form>
</body>
</html>

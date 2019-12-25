<%@ Page Language="C#" AutoEventWireup="true" CodeFile="practice3.aspx.cs" Inherits="practice3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        OrderId:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        ProductID:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        UnitPrice:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Quanity:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Discount:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Height="27px" OnClick="Button1_Click" Text="新增" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="3">
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>

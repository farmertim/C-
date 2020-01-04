<%@ Page Language="C#" AutoEventWireup="true" CodeFile="practice2.aspx.cs" Inherits="practice2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        OrderID:<asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        ProductID:<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        UnitPrice:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Quantity:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        Discount:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="新增" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>

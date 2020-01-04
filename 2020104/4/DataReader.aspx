<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataReader.aspx.cs" Inherits="DataReader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCommand="GridView1_RowCommand" PageSize="5">
            <Columns>
                <asp:ButtonField Text="按鈕" CommandName="button" />
            </Columns>
        </asp:GridView>
        <br />
        name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        account<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        password:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        Update id:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="insert" />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

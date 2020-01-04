<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Gridview.aspx.cs" Inherits="Gridview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" OnRowCommand="GridView1_RowCommand">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="帳號" HeaderText="帳號" SortExpression="帳號" />
                <asp:BoundField DataField="密碼" HeaderText="密碼" SortExpression="密碼" />
                <asp:ButtonField ButtonType="Button" CommandName="insert" Text="新增" />
                <asp:ButtonField ButtonType="Button" CommandName="delete1" Text="刪除" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [客戶資料]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>

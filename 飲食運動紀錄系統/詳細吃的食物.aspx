<%@ Page Language="C#" AutoEventWireup="true" CodeFile="詳細吃的食物.aspx.cs" Inherits="vu_6vu4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #image{
            text-align:right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div id="image">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="16px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="33px" /></div>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="16px" Width="1177px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
            <EditRowStyle BackColor="#999999" />
            <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
            <Fields>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="食物名稱" HeaderText="食物名稱" SortExpression="食物名稱" />
                <asp:BoundField DataField="熱量" HeaderText="熱量" SortExpression="熱量" />
                <asp:BoundField DataField="蛋白質" HeaderText="蛋白質" SortExpression="蛋白質" />
                <asp:BoundField DataField="脂肪" HeaderText="脂肪" SortExpression="脂肪" />
                <asp:BoundField DataField="碳水化合物" HeaderText="碳水化合物" SortExpression="碳水化合物" />
                <asp:BoundField DataField="糖" HeaderText="糖" SortExpression="糖" />
                <asp:BoundField DataField="膳食纖維" HeaderText="膳食纖維" SortExpression="膳食纖維" />
                <asp:BoundField DataField="鈉" HeaderText="鈉" SortExpression="鈉" />
                <asp:BoundField DataField="鈣" HeaderText="鈣" SortExpression="鈣" />
                <asp:BoundField DataField="時段" HeaderText="時段" SortExpression="時段" />
                <asp:BoundField DataField="日期" HeaderText="日期" SortExpression="日期" />
                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
            </Fields>
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        </asp:DetailsView>
        <br />
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [飲食紀錄] WHERE ([Id] = @Id)" DeleteCommand="DELETE FROM [飲食紀錄] WHERE [Id] = @Id" InsertCommand="INSERT INTO [飲食紀錄] ([姓名], [食物名稱], [熱量], [蛋白質], [脂肪], [碳水化合物], [糖], [膳食纖維], [鈉], [鈣], [時段], [日期]) VALUES (@姓名, @食物名稱, @熱量, @蛋白質, @脂肪, @碳水化合物, @糖, @膳食纖維, @鈉, @鈣, @時段, @日期)" UpdateCommand="UPDATE [飲食紀錄] SET [姓名] = @姓名, [食物名稱] = @食物名稱, [熱量] = @熱量, [蛋白質] = @蛋白質, [脂肪] = @脂肪, [碳水化合物] = @碳水化合物, [糖] = @糖, [膳食纖維] = @膳食纖維, [鈉] = @鈉, [鈣] = @鈣, [時段] = @時段, [日期] = @日期 WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="食物名稱" Type="String" />
                <asp:Parameter Name="熱量" Type="Double" />
                <asp:Parameter Name="蛋白質" Type="Double" />
                <asp:Parameter Name="脂肪" Type="Double" />
                <asp:Parameter Name="碳水化合物" Type="Double" />
                <asp:Parameter Name="糖" Type="Double" />
                <asp:Parameter Name="膳食纖維" Type="Double" />
                <asp:Parameter Name="鈉" Type="Double" />
                <asp:Parameter Name="鈣" Type="Double" />
                <asp:Parameter Name="時段" Type="String" />
                <asp:Parameter DbType="Date" Name="日期" />
            </InsertParameters>
            <SelectParameters>
                <asp:QueryStringParameter Name="Id" QueryStringField="Id" Type="Int32" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="食物名稱" Type="String" />
                <asp:Parameter Name="熱量" Type="Double" />
                <asp:Parameter Name="蛋白質" Type="Double" />
                <asp:Parameter Name="脂肪" Type="Double" />
                <asp:Parameter Name="碳水化合物" Type="Double" />
                <asp:Parameter Name="糖" Type="Double" />
                <asp:Parameter Name="膳食纖維" Type="Double" />
                <asp:Parameter Name="鈉" Type="Double" />
                <asp:Parameter Name="鈣" Type="Double" />
                <asp:Parameter Name="時段" Type="String" />
                <asp:Parameter DbType="Date" Name="日期" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>

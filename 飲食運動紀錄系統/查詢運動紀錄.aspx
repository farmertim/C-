<%@ Page Language="C#" AutoEventWireup="true" CodeFile="查詢運動紀錄.aspx.cs" Inherits="查詢運動紀錄" MaintainScrollPositionOnPostback="true" %>

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
    <div style="font-size: 24px">
    <div id="image">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="21px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="50px" /></div>
        查詢日期:<asp:TextBox ID="TextBox1" runat="server" BackColor="Yellow" Height="19px" TextMode="Date" Width="211px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Height="27px" Text="確認" Width="59px" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Height="22px" Width="1231px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                <asp:BoundField DataField="運動項目" HeaderText="運動項目" SortExpression="運動項目" />
                <asp:BoundField DataField="使用器材" HeaderText="使用器材" SortExpression="使用器材" />
                <asp:BoundField DataField="組數" HeaderText="組數" SortExpression="組數" />
                <asp:BoundField DataField="次數" HeaderText="次數" SortExpression="次數" />
                <asp:BoundField DataField="運動多久" HeaderText="運動多久" SortExpression="運動多久" />
                <asp:BoundField DataField="地點" HeaderText="地點" SortExpression="地點" />
                <asp:BoundField DataField="運動日期" HeaderText="運動日期" SortExpression="運動日期" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" DeleteCommand="DELETE FROM [運動紀錄] WHERE [Id] = @Id" InsertCommand="INSERT INTO [運動紀錄] ([姓名], [運動項目], [使用器材], [組數], [次數], [運動多久], [地點], [運動日期]) VALUES (@姓名, @運動項目, @使用器材, @組數, @次數, @運動多久, @地點, @運動日期)" SelectCommand="SELECT * FROM [運動紀錄] WHERE (([運動日期] = @運動日期) AND ([姓名] = @姓名))" UpdateCommand="UPDATE [運動紀錄] SET [姓名] = @姓名, [運動項目] = @運動項目, [使用器材] = @使用器材, [組數] = @組數, [次數] = @次數, [運動多久] = @運動多久, [地點] = @地點, [運動日期] = @運動日期 WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="運動項目" Type="String" />
                <asp:Parameter Name="使用器材" Type="String" />
                <asp:Parameter Name="組數" Type="Int32" />
                <asp:Parameter Name="次數" Type="Int32" />
                <asp:Parameter Name="運動多久" Type="Int32" />
                <asp:Parameter Name="地點" Type="String" />
                <asp:Parameter DbType="Date" Name="運動日期" />
            </InsertParameters>
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" DbType="Date" Name="運動日期" PropertyName="Text" />
                <asp:QueryStringParameter Name="姓名" QueryStringField="姓名" Type="String" />
            </SelectParameters>
            <UpdateParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="運動項目" Type="String" />
                <asp:Parameter Name="使用器材" Type="String" />
                <asp:Parameter Name="組數" Type="Int32" />
                <asp:Parameter Name="次數" Type="Int32" />
                <asp:Parameter Name="運動多久" Type="Int32" />
                <asp:Parameter Name="地點" Type="String" />
                <asp:Parameter DbType="Date" Name="運動日期" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:GridView ID="GridView2" runat="server" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" Height="116px" Width="602px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField></asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                查無資料
            </EmptyDataTemplate>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="回主畫面" />
    
    </div>
    </form>
</body>
</html>

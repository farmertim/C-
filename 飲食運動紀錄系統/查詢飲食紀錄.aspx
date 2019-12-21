<%@ Page Language="C#" AutoEventWireup="true" CodeFile="查詢飲食紀錄.aspx.cs" Inherits="查詢飲食紀錄" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .page{
            margin-left:auto;
            margin-right:auto;
            width:1000px;
        }
        .check{
            width:90%;
            margin-left:auto;
            margin-right:auto;

        }
       
        .auto-style1 {
            width: 39%;
            margin-left: auto;
            margin-right: auto;
        }
        .auto-style2 {
            width: 422px;
        }
        .auto-style3 {
            text-align:center;
            width: 489px;
            height: 40px;
        }
        .auto-style4 {
            margin-left: auto;
            margin-right: auto;
            width: 1064px;
            height: 961px;
        }
        .auto-style5 {
            width: 838px;
        }
        #image{
            text-align:right;
        }

        .auto-style6 {
            margin-right: 2px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div id="image">
          <asp:ImageButton ID="ImageButton1" runat="server" Height="31px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="54px" /></div>
    <div class="auto-style4" style="border-style: solid; border-width: 2px; background-color:dodgerblue;">

    <table class="auto-style1">
        <tr class="auto-style2"> 
            <td class="auto-style5" >
                  <h1 class="auto-style3">查詢飲食紀錄</h1>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="border-style: solid; border-width: 1px; font-size: 30px">
                 
                <br />
                 
                選擇查詢日期:<asp:TextBox ID="TextBox1" runat="server" TextMode="Date" AutoPostBack="True" Height="25px" Width="206px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Height="40px" Width="497px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
                    <AlternatingRowStyle BackColor="PaleGoldenrod" />
                    <Columns>
                        <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                        <asp:BoundField DataField="食物名稱" HeaderText="食物名稱" SortExpression="食物名稱" />
                        <asp:BoundField DataField="熱量" HeaderText="熱量" SortExpression="熱量" />
                        <asp:BoundField DataField="日期" HeaderText="日期" SortExpression="日期" />
                        <asp:HyperLinkField DataNavigateUrlFields="Id,姓名" DataNavigateUrlFormatString="詳細吃的食物.aspx?Id={0}&amp;姓名={1}" DataTextField="姓名" DataTextFormatString="{0}吃的食物明細" HeaderText="詳細清單" />
                    </Columns>
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
            </td>
        </tr>
    </table>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" DataKeyNames="Id" DataSourceID="SqlDataSource2" GridLines="None" Height="75px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" Width="985px" AllowPaging="True" CssClass="auto-style6">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
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
                <asp:TemplateField></asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                查無資料
            </EmptyDataTemplate>
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        .<br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [飲食紀錄] WHERE (([日期] = @日期) AND ([姓名] = @姓名))">
            <SelectParameters>
                <asp:ControlParameter ControlID="TextBox1" DbType="Date" Name="日期" PropertyName="Text" />
                <asp:QueryStringParameter Name="姓名" QueryStringField="姓名" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [飲食紀錄] WHERE ([姓名] = @姓名)" DeleteCommand="DELETE FROM [飲食紀錄] WHERE [Id] = @Id" InsertCommand="INSERT INTO [飲食紀錄] ([姓名], [食物名稱], [熱量], [蛋白質], [脂肪], [碳水化合物], [糖], [膳食纖維], [鈉], [鈣], [時段], [日期]) VALUES (@姓名, @食物名稱, @熱量, @蛋白質, @脂肪, @碳水化合物, @糖, @膳食纖維, @鈉, @鈣, @時段, @日期)" UpdateCommand="UPDATE [飲食紀錄] SET [姓名] = @姓名, [食物名稱] = @食物名稱, [熱量] = @熱量, [蛋白質] = @蛋白質, [脂肪] = @脂肪, [碳水化合物] = @碳水化合物, [糖] = @糖, [膳食纖維] = @膳食纖維, [鈉] = @鈉, [鈣] = @鈣, [時段] = @時段, [日期] = @日期 WHERE [Id] = @Id">
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
                <asp:QueryStringParameter Name="姓名" QueryStringField="姓名" Type="String" />
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
    </div>
    </form>
</body>
</html>

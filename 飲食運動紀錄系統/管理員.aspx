<%@ Page Language="C#" AutoEventWireup="true" CodeFile="管理員.aspx.cs" Inherits="管理員" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Page{
            width:1000px;
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .t{
            width:80px;
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .t1{
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style1 {
            width: 906px;
            text-align: right;
            margin-left: auto;
            margin-right: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="page">
    <table class="auto-style1">
        <tr >
            <td class="t1">
                <h2>飲食運動管理員</h2>
                <p>&nbsp;</p>
                查詢人員<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="姓名" DataValueField="姓名" Height="24px" Width="178px"></asp:DropDownList>
                &nbsp; 查詢日期:<asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" Height="17px" TextMode="Date" Width="190px"></asp:TextBox>
                <br />
                <h2>飲食管理</h2>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" CellPadding="4" ForeColor="#333333" GridLines="None" Width="894px" AllowPaging="True" PageSize="6" Height="280px">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
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
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <EmptyDataTemplate>
                        
                    </EmptyDataTemplate>
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
                <br />
            </td>

        </tr>
           <tr >
            <td class="t1">
                <h2>運動紀錄</h2>
                
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" CellPadding="4" ForeColor="#333333" GridLines="None" Width="889px" AllowPaging="True" PageSize="6">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                        <asp:BoundField DataField="運動項目" HeaderText="運動項目" SortExpression="運動項目" />
                        <asp:BoundField DataField="使用器材" HeaderText="使用器材" SortExpression="使用器材" />
                        <asp:BoundField DataField="組數" HeaderText="組數" SortExpression="組數" />
                        <asp:BoundField DataField="次數" HeaderText="次數" SortExpression="次數" />
                        <asp:BoundField DataField="運動多久" HeaderText="運動多久" SortExpression="運動多久" />
                        <asp:BoundField DataField="地點" HeaderText="地點" SortExpression="地點" />
                        <asp:BoundField DataField="運動日期" HeaderText="運動日期" SortExpression="運動日期" />
                    </Columns>
                    <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                    <SortedAscendingCellStyle BackColor="#FDF5AC" />
                    <SortedAscendingHeaderStyle BackColor="#4D0000" />
                    <SortedDescendingCellStyle BackColor="#FCF6C0" />
                    <SortedDescendingHeaderStyle BackColor="#820000" />
                </asp:GridView>
            </td>
        </tr>
         <tr >
            <td class="t1">
                <h2>體態紀錄</h2>
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="SqlDataSource4" ForeColor="Black" GridLines="Vertical" Width="895px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                        <asp:BoundField DataField="身高" HeaderText="身高" SortExpression="身高" />
                        <asp:BoundField DataField="bmi" HeaderText="bmi" SortExpression="bmi" />
                        <asp:BoundField DataField="體重" HeaderText="體重" SortExpression="體重" />
                        <asp:BoundField DataField="剩餘熱量" HeaderText="剩餘熱量" SortExpression="剩餘熱量" />
                        <asp:BoundField DataField="基礎代謝率" HeaderText="基礎代謝率" SortExpression="基礎代謝率" />
                        <asp:BoundField DataField="日期" HeaderText="日期" SortExpression="日期" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FBFBF2" />
                    <SortedAscendingHeaderStyle BackColor="#848384" />
                    <SortedDescendingCellStyle BackColor="#EAEAD3" />
                    <SortedDescendingHeaderStyle BackColor="#575357" />
                </asp:GridView>
                </td>
             </tr>
    </table>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" DeleteCommand="DELETE FROM [客戶資料] WHERE [Id] = @Id" InsertCommand="INSERT INTO [客戶資料] ([姓名], [帳號], [密碼]) VALUES (@姓名, @帳號, @密碼)" SelectCommand="SELECT * FROM [客戶資料]" UpdateCommand="UPDATE [客戶資料] SET [姓名] = @姓名, [帳號] = @帳號, [密碼] = @密碼 WHERE [Id] = @Id">
            <DeleteParameters>
                <asp:Parameter Name="Id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="帳號" Type="String" />
                <asp:Parameter Name="密碼" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="姓名" Type="String" />
                <asp:Parameter Name="帳號" Type="String" />
                <asp:Parameter Name="密碼" Type="String" />
                <asp:Parameter Name="Id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT [姓名], [食物名稱], [熱量], [蛋白質], [脂肪], [碳水化合物], [糖], [膳食纖維], [鈉], [鈣], [時段], [日期] FROM [飲食紀錄] WHERE (([姓名] = @姓名) AND ([日期] = @日期))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="姓名" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="TextBox1" DbType="Date" Name="日期" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT [姓名], [運動項目], [使用器材], [組數], [次數], [運動多久], [地點], [運動日期] FROM [運動紀錄] WHERE (([姓名] = @姓名) AND ([運動日期] = @運動日期))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="姓名" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="TextBox1" DbType="Date" Name="運動日期" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT [姓名], [身高], [bmi], [體重], [剩餘熱量], [基礎代謝率], [日期] FROM [體態紀錄] WHERE (([姓名] = @姓名) AND ([日期] = @日期))">
            <SelectParameters>
                <asp:ControlParameter ControlID="DropDownList1" Name="姓名" PropertyName="SelectedValue" Type="String" />
                <asp:ControlParameter ControlID="TextBox1" DbType="Date" Name="日期" PropertyName="Text" />
            </SelectParameters>
        </asp:SqlDataSource>
        <br />
    </div>
    </form>
</body>
</html>

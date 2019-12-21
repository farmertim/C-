<%@ Page Language="C#" AutoEventWireup="true" CodeFile="新增運動內容.aspx.cs" Inherits="新增運動內容" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style >
        #MainContainer{
            width: 1000px;
            height: 554px;
            margin-left:auto;
            margin-right:auto;
        }
        table{
           
            margin-left:auto;
            margin-right:auto;
            text-align:center;
            width:80%;
        }
        #image{
            text-align:right;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div id="MainContainer">
    
    <div id="image">
        <asp:ImageButton ID="ImageButton1" runat="server" Height="21px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="36px" /></div>
        <table class="auto-style1">
            <tr>
                <td>
    
        <asp:FormView ID="FormView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="Id" DataSourceID="SqlDataSource1" DefaultMode="Insert" GridLines="Both" Height="250px" Width="437px" OnPageIndexChanging="FormView1_PageIndexChanging">
            <EditItemTemplate>
                Id:
                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                <br />
                姓名:
                <asp:TextBox ID="姓名TextBox" runat="server" Text='<%# Bind("姓名") %>' />
                <br />
                運動項目:
                <asp:TextBox ID="運動項目TextBox" runat="server" Text='<%# Bind("運動項目") %>' />
                <br />
                使用器材:
                <asp:TextBox ID="使用器材TextBox" runat="server" Text='<%# Bind("使用器材") %>' />
                <br />
                組數:
                <asp:TextBox ID="組數TextBox" runat="server" Text='<%# Bind("組數") %>' />
                <br />
                次數:
                <asp:TextBox ID="次數TextBox" runat="server" Text='<%# Bind("次數") %>' />
                <br />
                運動多久:
                <asp:TextBox ID="運動多久TextBox" runat="server" Text='<%# Bind("運動多久") %>' />
                <br />
                地點:
                <asp:TextBox ID="地點TextBox" runat="server" Text='<%# Bind("地點") %>' />
                <br />
                運動日期:
                <asp:TextBox ID="運動日期TextBox" runat="server" Text='<%# Bind("運動日期") %>' />
                <br />
                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
            </EditItemTemplate>
            <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
            <HeaderTemplate>
                運動紀錄
            </HeaderTemplate>
            <InsertItemTemplate>
                姓名:
                <asp:TextBox ID="姓名TextBox" runat="server" Enabled="False" Text='<%# Bind("姓名") %>' />
                <br />
                <br />
                運動項目:
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource2" DataTextField="器材名稱" DataValueField="器材名稱" Height="23px" SelectedValue='<%# Bind("運動項目") %>' Width="215px">
                </asp:DropDownList>
                <br />
                <br />
                使用器材:
                <asp:TextBox ID="使用器材TextBox" runat="server" Text='<%# Bind("使用器材") %>' />
                <br />
                <br />
                組數:
                <asp:TextBox ID="組數TextBox" runat="server" Text='<%# Bind("組數") %>' />
                <br />
                <br />
                次數:
                <asp:TextBox ID="次數TextBox" runat="server" Text='<%# Bind("次數") %>' />
                <br />
                <br />
                運動多久:
                <asp:TextBox ID="運動多久TextBox" runat="server" Text='<%# Bind("運動多久") %>' />
                <br />
                <br />
                地點:
                <asp:TextBox ID="地點TextBox" runat="server" Text='<%# Bind("地點") %>' />
                <br />
                <br />
                運動日期:
                <asp:TextBox ID="運動日期TextBox" runat="server" Text='<%# Bind("運動日期") %>' TextMode="Date" />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="檢 查" />
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="插入" Enabled="False" OnClick="InsertButton_Click1" />
                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
            </InsertItemTemplate>
            <ItemTemplate>
                姓名:
                <asp:Label ID="姓名Label" runat="server" Text='<%# Bind("姓名") %>' />
                <br />
                運動項目:
                <asp:Label ID="運動項目Label" runat="server" Text='<%# Bind("運動項目") %>' />
                <br />
                使用器材:
                <asp:Label ID="使用器材Label" runat="server" Text='<%# Bind("使用器材") %>' />
                <br />
                組數:
                <asp:Label ID="組數Label" runat="server" Text='<%# Bind("組數") %>' />
                <br />
                次數:
                <asp:Label ID="次數Label" runat="server" Text='<%# Bind("次數") %>' />
                <br />
                運動多久:
                <asp:Label ID="運動多久Label" runat="server" Text='<%# Bind("運動多久") %>' />
                <br />
                地點:
                <asp:Label ID="地點Label" runat="server" Text='<%# Bind("地點") %>' />
                <br />
                運動日期:
                <asp:Label ID="運動日期Label" runat="server" Text='<%# Bind("運動日期") %>' />
                <br />
                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯" />
&nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" />
                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="新增" />
            </ItemTemplate>
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#330099" />
        </asp:FormView>
                    <br />
                    <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" DeleteCommand="DELETE FROM [運動紀錄] WHERE [Id] = @Id" InsertCommand="INSERT INTO [運動紀錄] ([姓名], [運動項目], [使用器材], [組數], [次數], [運動多久], [地點], [運動日期]) VALUES (@姓名, @運動項目, @使用器材, @組數, @次數, @運動多久, @地點, @運動日期)" SelectCommand="SELECT * FROM [運動紀錄]" UpdateCommand="UPDATE [運動紀錄] SET [姓名] = @姓名, [運動項目] = @運動項目, [使用器材] = @使用器材, [組數] = @組數, [次數] = @次數, [運動多久] = @運動多久, [地點] = @地點, [運動日期] = @運動日期 WHERE [Id] = @Id">
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
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [運動器材]"></asp:SqlDataSource>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
           
            </tr>
        
        </table>
    
    
    </div>
    </form>
</body>
</html>

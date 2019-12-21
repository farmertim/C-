<%@ Page Language="C#" AutoEventWireup="true" CodeFile="使用者頁面.aspx.cs" Inherits="使用者頁面" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #auto-style1 {
        }
        div {
           border-color: black;
        }
        tr,td{
          
        border-color:black;
        }
        body {
         
            text-align: center;
            background-color: aqua;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 100%;
            height: 58px;
        }
        .auto-style3 {
            width: 100%;
            height: 93px;
        }
        #image{
            text-align:right;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div id="image">
            <asp:ImageButton ID="ImageButton7" runat="server" Height="23px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton7_Click" Width="35px" />
        </div>
        <div class="suto-style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<table class="auto-style3">
                <tr>
                    <td style="border-style: solid; border-color: #000000; background-color: #00FF00;">
                        <asp:Label ID="Label3" runat="server" Font-Size="X-Large" Text="Label"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="運動飲食管理系統" Font-Size="XX-Large"></asp:Label>
                    </td>
                  
                </tr>
               
            </table>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;</div>
        <div style="width: 100px">
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Font-Size="X-Large" Font-Bold="False">
                <asp:ListItem>運動紀錄</asp:ListItem>
                <asp:ListItem>飲食紀錄</asp:ListItem>
                <asp:ListItem>身體狀況紀錄</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="auto-style1" style="border-style: solid; border-color: #000080;">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label2" runat="server" Text="運動紀錄" Font-Size="XX-Large" BackColor="#FFFF99"></asp:Label>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server" Height="414px" BorderColor="#FFFF66">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <asp:ImageButton ID="ImageButton1" runat="server" Height="180px" ImageUrl="~/健身房.jpg" OnClick="ImageButton1_Click" Width="551px" ToolTip="新增內容" />
                <br />
                <br />
                <asp:ImageButton ID="ImageButton2" runat="server" Height="181px" ImageUrl="~/健身房2.jpg" OnClick="ImageButton2_Click" ToolTip="查詢修改內容" Width="556px" />
            </asp:Panel>
            <asp:Panel ID="Panel3" runat="server" Height="364px">
                <asp:ImageButton ID="ImageButton3" runat="server" Height="161px" ImageUrl="~/飲食.jpg" ToolTip="紀錄飲食" Width="549px" OnClick="ImageButton3_Click" />
                <br />
                <br />
                <asp:ImageButton ID="ImageButton4" runat="server" Height="184px" ImageUrl="~/飲食2.jpg" ToolTip="查詢飲食狀態" Width="551px" OnClick="ImageButton4_Click" />
                <br />
            </asp:Panel>
            <asp:Panel ID="Panel4" runat="server" Height="403px">
                <asp:ImageButton ID="ImageButton5" runat="server" Height="153px" ImageUrl="~/體態紀錄.jpg" ToolTip="體態紀錄" Width="543px" OnClick="ImageButton5_Click" />
                <br />
                <br />
                <asp:ImageButton ID="ImageButton6" runat="server" Height="184px" ImageUrl="~/查詢體態紀錄.jpg" ToolTip="查詢體態紀錄" Width="531px" OnClick="ImageButton6_Click" />
            </asp:Panel>
            <br />
            <br />
            <br />
            <br />
            <br />



        </div>
        <p class="auto-style2">
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
        </p>
    </form>
</body>
</html>

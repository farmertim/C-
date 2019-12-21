<%@ Page Language="C#" AutoEventWireup="true" CodeFile="新增帳號.aspx.cs" Inherits="新增帳號" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #c {
            min-width: 800px;
           margin-left:auto;
           margin-right:auto;
            text-align: center;
        }

        .r {
            min-width:80%;
         margin-left:auto;
           margin-right:auto;
            text-align: center;
        }

        .record {
             min-width: 80%;
           margin-left:auto;
           margin-right:auto;
            text-align: center;
        }
        .auto-style1 {
            min-width: 80%;
            margin-left:auto;
           margin-right:auto;
            text-align: center;
       
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="c">
            <table class="auto-style1">
                 <tr class="record">
                    <td >
                        <h1 >註冊帳號</h1>
                        </td>
                     </tr>
                <tr class="record">
                    <td >
                        <asp:FormView ID="FormView2" runat="server" DataSourceID="SqlDataSource1" DefaultMode="Insert" OnPageIndexChanging="FormView2_PageIndexChanging" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" Width="1137px" Height="232px" DataKeyNames="Id">
                            <EditItemTemplate>
                                Id:
                                <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                                <br />
                                姓名:
                                <asp:TextBox ID="姓名TextBox" runat="server" Text='<%# Bind("姓名") %>' />
                                <br />
                                帳號:
                                <asp:TextBox ID="帳號TextBox" runat="server" Text='<%# Bind("帳號") %>' />
                                <br />
                                密碼:
                                <asp:TextBox ID="密碼TextBox" runat="server" Text='<%# Bind("密碼") %>' />
                                <br />
                                <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="更新" />
                                &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                            </EditItemTemplate>
                            <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                            <InsertItemTemplate>
                                姓名:
                                <asp:TextBox ID="姓名TextBox" runat="server" Text='<%# Bind("姓名") %>' />
                                <br />
                                <br />
                                帳號:
                                <asp:TextBox ID="帳號TextBox" runat="server" Text='<%# Bind("帳號") %>' />
                                <br />
                                <br />
                                密碼:
                                <asp:TextBox ID="密碼TextBox" runat="server" Text='<%# Bind("密碼") %>' />
                                <br />
                                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="檢查" />
                                <br />
                                <asp:Label ID="Label1" runat="server"></asp:Label>
                                <br />
                                <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="新增" OnClick="InsertButton_Click" Enabled="False" />
                                &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="取消" />
                            </InsertItemTemplate>
                            <ItemTemplate>
                                Id:
                                <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                                <br />
                                姓名:
                                <asp:Label ID="姓名Label" runat="server" Text='<%# Bind("姓名") %>' />
                                <br />
                                帳號:
                                <asp:Label ID="帳號Label" runat="server" Text='<%# Bind("帳號") %>' />
                                <br />
                                密碼:
                                <asp:Label ID="密碼Label" runat="server" Text='<%# Bind("密碼") %>' />
                                <br />
                                <asp:LinkButton ID="EditButton" runat="server" CausesValidation="False" CommandName="Edit" Text="編輯" />
                                &nbsp;<asp:LinkButton ID="DeleteButton" runat="server" CausesValidation="False" CommandName="Delete" Text="刪除" />
                                &nbsp;<asp:LinkButton ID="NewButton" runat="server" CausesValidation="False" CommandName="New" Text="新增" />
                            </ItemTemplate>
                            <PagerStyle ForeColor="#330099" HorizontalAlign="Center" BackColor="#FFFFCC" />
                            <RowStyle BackColor="White" ForeColor="#330099" />
                        </asp:FormView>
                        <br />
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" InsertCommand="INSERT INTO [客戶資料] ([姓名], [帳號], [密碼]) VALUES (@姓名, @帳號, @密碼)" SelectCommand="SELECT * FROM [客戶資料]" DeleteCommand="DELETE FROM [客戶資料] WHERE [Id] = @Id" UpdateCommand="UPDATE [客戶資料] SET [姓名] = @姓名, [帳號] = @帳號, [密碼] = @密碼 WHERE [Id] = @Id">
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

                        <asp:Button ID="Button1" runat="server" Text="回登陸畫面" OnClick="Button1_Click" />
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="飲食紀錄.aspx.cs" Inherits="飲食紀錄" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            width: 900px;
            margin-left: auto;
            margin-right: auto;
        }

        .time {
            width: 80%;
            margin-left: auto;
            margin-right: auto;
            border-color: black;
        }

        .auto-style1 {
            width: 80%;
            margin-left: auto;
            margin-right: auto;
            height: 235px;
        }

        .auto-style2 {
            height: 285px;
        }

        #image {
            text-align: right;
        }

        #record {
            margin-left: auto;
            margin-right: auto;
            text-align: left;
        }
        h1{
            text-align:center;
        }
        .auto-style3 {
            width: 914px;
        }
        .auto-style4 {
            width: 903px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="image">
            <asp:ImageButton ID="ImageButton1" runat="server" Height="21px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="40px" />
        </div>
        <h1>食物紀錄</h1>
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" style="border-style: solid; border-color: #000000; font-size: 26px; background-color: #99FF99;">
                    <br />
                    選擇時段:<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem>早上</asp:ListItem>
                        <asp:ListItem>中午</asp:ListItem>
                        <asp:ListItem>晚上</asp:ListItem>
                        <asp:ListItem>其他</asp:ListItem>
                    </asp:RadioButtonList>
                    <br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Height="33px" OnClick="Button1_Click" Text="自訂" Width="86px" />
                    &nbsp;<asp:Button ID="Button2" runat="server" Height="32px" OnClick="Button2_Click" Text="選擇" Width="79px" />
                    <br />
                    <br />
                      <asp:Panel ID="Panel1" runat="server" Height="151px" BorderColor="#6699FF" Width="912px">
                                
                    <table class="record">
                        <tr>
                            <td style="border: 2px solid #0000FF" class="auto-style4">
                                  食&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 物:<asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="食物名稱" DataValueField="食物名稱">
                                    </asp:DropDownList>
                                    <br />
                                    份&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 數:<asp:TextBox ID="TextBox1" runat="server" TextMode="Number"></asp:TextBox>
                                    <br />
                                    今日日期:<asp:TextBox ID="TextBox2" runat="server" TextMode="Date"></asp:TextBox>
                                    <br />
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
                                    <br />
                                    <asp:Button ID="Button4" runat="server" Height="39px" OnClick="Button4_Click" Text="紀錄" Width="78px" />
                              
                            </td>

                        </tr>
                    </table>
                      </asp:Panel>
                     <asp:Panel ID="Panel2" runat="server" Height="317px" Width="914px">
                     <table class="record">
                        <tr>
                            <td style="border: 2px solid #0000FF" class="auto-style3">
                   
                        &nbsp;&nbsp;&nbsp; 食&nbsp;&nbsp; 物&nbsp;&nbsp; 名&nbsp;&nbsp;&nbsp;&nbsp; 稱:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp; 熱&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 量(大卡):<asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp; 蛋&nbsp; 白&nbsp; 質(公克):<asp:TextBox ID="TextBox5" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 脂&nbsp;&nbsp; 肪(公克):<asp:TextBox ID="TextBox6" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 糖(公克):<asp:TextBox ID="TextBox8" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        碳水化合物(公克):<asp:TextBox ID="TextBox9" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        &nbsp;膳 食 纖 維(公克):<asp:TextBox ID="TextBox10" runat="server" TextMode="Number" Height="23px"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 鈉(毫克):<asp:TextBox ID="TextBox11" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 鈣(毫克):<asp:TextBox ID="TextBox14" runat="server" TextMode="Number"></asp:TextBox>
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp; 今&nbsp;&nbsp; 日&nbsp;&nbsp; 日&nbsp;&nbsp; 期:<asp:TextBox ID="TextBox13" runat="server" TextMode="Date"></asp:TextBox>
                                <br />
                                <asp:Label ID="Label2" runat="server"></asp:Label>
                        <br />
                        <asp:Button ID="Button3" runat="server" Height="39px" OnClick="Button3_Click" Text="紀錄" Width="103px" />
                        <br />
                  
                                       </td>

                        </tr>
                    </table>
                      </asp:Panel>
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>

        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [食物名稱]"></asp:SqlDataSource>
        <br />

        </div>
    </form>
</body>
</html>

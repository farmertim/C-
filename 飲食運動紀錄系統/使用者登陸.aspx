<%@ Page Language="C#" AutoEventWireup="true" CodeFile="使用者登陸.aspx.cs" Inherits="使用者登陸" MaintainScrollPositionOnPostback="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            background-color: antiquewhite;
            margin-left: auto;
            margin-right: auto;
        }

        #name {
            width: 1000px;
            margin-left: auto;
            margin-right: auto;
        }

        .table {
            width:80%;
            margin-left: auto;
            margin-right: auto;
           
        }
        .auto-style1 {
            width: 26%;
             margin-top:150px;
            margin-left: auto;
            margin-right: auto;
            height: 293px;
        }
        .auto-style2 {
            width: 47%;
            background-color:aqua;
            margin-top: 150px;
            margin-left: auto;
            margin-right: auto;
            height: 324px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="name">

            <table class="auto-style2">
                <tr>
                   
                    <td class="auto-style1">
                        <h1 style="text-align:center">飲食與運動記錄</h1>
                         <h3 style="text-align:center">登入</h3>
                         <p style="text-align:center">----------------------------------------------------------</p>
                        &nbsp; 帳&nbsp; 號:<asp:TextBox ID="TextBox1" runat="server" Width="254px"></asp:TextBox>
                       
                         <br />
                       
                        <br />
                        &nbsp;密&nbsp;&nbsp; 碼:<asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="255px"></asp:TextBox>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="登陸" OnClick="Button1_Click" />
                        &nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Text="註冊" OnClick="Button2_Click" />

                    &nbsp;
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="忘記密碼" />

                    </td>

                </tr>

            </table>
            <br />
            <br />

            <br />

        </div>
    </form>
</body>
</html>

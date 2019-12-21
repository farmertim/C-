<%@ Page Language="C#" AutoEventWireup="true" CodeFile="體態紀錄.aspx.cs" Inherits="體態紀錄" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #import{
            width:1000px;
            margin-left:auto;
            margin-right:auto;

        }
        table{
            width:90%;
             margin-left:auto;
            margin-right:auto;
        }
        h1{
            text-align:center;
        }
        #image{
            text-align:right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="import">

       
    <table>
        <tr>
            <td >
                <div id="image"><asp:ImageButton ID="ImageButton1" runat="server" Height="26px" ImageUrl="~/叉叉.jpg" OnClick="ImageButton1_Click" Width="39px" /></div>
                 <h1>體態紀錄</h1>

                身高:<asp:TextBox ID="TextBox1" runat="server" placeholder="輸入身高(CM)"></asp:TextBox>
                <br />
                <br />
                體重:<asp:TextBox ID="TextBox2" runat="server" placeholder="輸入體重(KG)"></asp:TextBox>
                <br />
                <br />
                年紀:<asp:TextBox ID="TextBox4" runat="server" TextMode="Number"></asp:TextBox>
                <br />
                <br />
                性別:<asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem>男</asp:ListItem>
                    <asp:ListItem>女</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <br />
                日期:<asp:TextBox ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <asp:Label ID="Label1" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="紀錄" style="height: 27px" />
                <br />
               

            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>

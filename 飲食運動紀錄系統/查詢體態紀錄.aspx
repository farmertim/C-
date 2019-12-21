<%@ Page Language="C#" AutoEventWireup="true" CodeFile="查詢體態紀錄.aspx.cs" Inherits="查詢體態紀錄" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .width{
            width:1000px;
            margin-left:auto;
            margin-right:auto;
        }
        .location{
            width:70%;
            margin-left:auto;
            margin-right:auto;
            text-align:center;
        }
         .location{
            text-align:center;
            margin-left:auto;
            margin-right:auto;
        }
        .auto-style1 {
            height: 93px;
        }
        #image{
            text-align:right;
           
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="width">
        
    <table class="location">
        <tr id="image">
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Height="32px" ImageUrl="~/叉叉.jpg" Width="38px" />
            </td>
        </tr>
         <tr class="location">
              <td class="auto-style1">
                  <h1>體態紀錄查詢</h1>
                  </td>
             </tr>
        <tr class="location">
            <td class="auto-style1">
                 查詢當日最新體態(日期):<asp:TextBox ID="TextBox1" runat="server" TextMode="Date" placeholder="依照日期查詢"></asp:TextBox>
                 <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            </td>
        </tr>
        <tr class="location">
            <td>

                <asp:Label ID="Label5" runat="server"></asp:Label>

            </td>
        </tr>
    </table>
       
       
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="剩餘蛋白質:"></asp:Label>
&nbsp;<asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:Label ID="Label4" runat="server" Text=" 剩 餘 熱 量:"></asp:Label>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
    
        <br />
     <table class="location">
         <tr class="location">
              <td class="auto-style1">
                  <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="788px" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                      <Columns>
                          <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                          <asp:BoundField DataField="身高" HeaderText="身高" SortExpression="身高" />
                          <asp:BoundField DataField="體重" HeaderText="體重" SortExpression="體重" />
                          <asp:BoundField DataField="bmi" HeaderText="bmi" SortExpression="bmi" />
                          <asp:BoundField DataField="剩餘熱量" HeaderText="剩餘熱量" SortExpression="剩餘熱量" />
                          <asp:BoundField DataField="基礎代謝率" HeaderText="基礎代謝率" SortExpression="基礎代謝率" />
                          <asp:BoundField DataField="日期" HeaderText="日期" SortExpression="日期" />
                          <asp:TemplateField></asp:TemplateField>
                      </Columns>
                      <EmptyDataTemplate>
                          查無資料
                      </EmptyDataTemplate>
                      <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                      <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                      <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                      <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                      <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                      <SortedAscendingCellStyle BackColor="#FFF1D4" />
                      <SortedAscendingHeaderStyle BackColor="#B95C30" />
                      <SortedDescendingCellStyle BackColor="#F1E5CE" />
                      <SortedDescendingHeaderStyle BackColor="#93451F" />
                  </asp:GridView>
                  <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [體態紀錄] WHERE ([姓名] = @姓名)">
                      <SelectParameters>
                          <asp:QueryStringParameter Name="姓名" QueryStringField="姓名" Type="String" />
                      </SelectParameters>
                  </asp:SqlDataSource>
                  </td>
             </tr>
         </table>
    </div>
    </form>
</body>
</html>

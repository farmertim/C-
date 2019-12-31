<%@ Page Language="C#" AutoEventWireup="true" CodeFile="practice.aspx.cs" Inherits="practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Interval="3000" OnTick="Timer1_Tick">
                </asp:Timer>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                    <ContentTemplate>
                        <asp:Timer ID="Timer2" runat="server" Interval="1000" OnTick="Timer2_Tick">
                        </asp:Timer>
                        <asp:Label ID="Label2" runat="server" Text="0"></asp:Label>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <br />
                <asp:Label ID="Label1" runat="server" Text="0"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        <br />
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Timer ID="Timer3" runat="server" Interval="3000" OnTick="Timer3_Tick">
                </asp:Timer>
                <asp:Label ID="Label3" runat="server" Text="0"></asp:Label>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="姓名" DataValueField="Id">
        </asp:DropDownList>
        <br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [客戶資料]"></asp:SqlDataSource>
        <br />
        <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                        <asp:BoundField DataField="姓名" HeaderText="姓名" SortExpression="姓名" />
                        <asp:BoundField DataField="帳號" HeaderText="帳號" SortExpression="帳號" />
                        <asp:BoundField DataField="密碼" HeaderText="密碼" SortExpression="密碼" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:運動與飲食紀錄ConnectionString %>" SelectCommand="SELECT * FROM [客戶資料] WHERE ([Id] = @Id)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="Id" PropertyName="SelectedValue" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <br />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="DropDownList1" EventName="SelectedIndexChanged" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:Image ID="Image1" runat="server" Height="65px" ImageUrl="~/下載 (1).jpg" Width="496px" />
        <br />
        <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                 <br />
        現在時間:<asp:Label ID="Label5" runat="server"></asp:Label>
        <br /><br /><asp:Timer ID="Timer4" runat="server" Interval="1000" OnTick="Timer4_Tick">
        </asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
        
        <br />
        歡迎光臨<br />
       
        <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                姓名:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
                電話:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                訂位時間:<asp:TextBox ID="TextBox3" runat="server" TextMode="Date"></asp:TextBox>
                <br />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
                <br />
                <asp:Label ID="Label4" runat="server"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

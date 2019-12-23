<%@ Page Language="C#" AutoEventWireup="true" CodeFile="資料繫結.aspx.cs" Inherits="資料繫結" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <div>
    
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
        </asp:CheckBoxList>
    
        <br />
        <asp:GridView ID="GridView1" runat="server" OnRowEditing="RowEditeing" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:CommandField ShowSelectButton="True" />
                <asp:CommandField ShowDeleteButton="True" />
            </Columns>
        </asp:GridView>
        <br />
    
    </div>
    </form>
</body>
</html>

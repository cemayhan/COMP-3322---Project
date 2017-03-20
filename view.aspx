<%@ Page Language="C#" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="view" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server" accept-charset="utf-8">
<asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
        <p>
            &nbsp;</p>
        <br />
        DataTable :&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Height="18px" Width="98px">
            <asp:ListItem>kullanici</asp:ListItem>
            <asp:ListItem>questions</asp:ListItem>
            <asp:ListItem>scores</asp:ListItem>
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Show Table" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        UnitTable :&nbsp;&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="156px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Empty Cells" />
        &nbsp;
        <p>
            &nbsp;</p>
    </form>
</body>
</html>

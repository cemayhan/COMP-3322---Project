<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChatGrade.aspx.cs" Inherits="ChatGrade" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

        <asp:DropDownList ID="DropDownList1" runat="server" Height="26px" Width="87px">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Button ID="Button1" runat="server" Height="26px" OnClick="Button1_Click" Text="Show" Width="77px" />
        <br />
        <br />
        <br />

        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
           
        </asp:PlaceHolder>
    
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="152px"></asp:TextBox>
        <br />
&nbsp;<asp:DropDownList ID="DropDownList2" runat="server" Height="74px" Width="160px">
            <asp:ListItem>andyramire350931</asp:ListItem>
            <asp:ListItem>chris</asp:ListItem>
            <asp:ListItem>maria69</asp:ListItem>
            <asp:ListItem>cristobal17</asp:ListItem>
            <asp:ListItem>angieovo</asp:ListItem>
            <asp:ListItem>rbelgara2001</asp:ListItem>
            <asp:ListItem>jasmyns</asp:ListItem>
            <asp:ListItem>salasss</asp:ListItem>
            <asp:ListItem>josstheboss</asp:ListItem>
            <asp:ListItem>EmanuelS</asp:ListItem>
            <asp:ListItem>alexander2603</asp:ListItem>
            <asp:ListItem>xxxLegendxxx</asp:ListItem>
            <asp:ListItem>genesis</asp:ListItem>
            <asp:ListItem>arturomedrano</asp:ListItem>
            <asp:ListItem>brandino</asp:ListItem>
            <asp:ListItem>micahle</asp:ListItem>
            <asp:ListItem>jonathansss</asp:ListItem>
            <asp:ListItem>lesleyojeda1</asp:ListItem>
        </asp:DropDownList>
&nbsp;
        <asp:Button ID="Button2" runat="server" Height="26px" Text="Grade" Width="77px" OnClick="Button2_Click" />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="input.aspx.cs" Inherits="input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server" accept-charset="utf-8">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="Please enter the words/sentences that students will work on as practice"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; UNIT NAME =&nbsp;
        <asp:TextBox ID="TextBox11" runat="server" Height="23px" MaxLength="16" Width="187px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Exercise 1:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Exercise 2:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Exercise 3:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Exercise 4:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Exercise 5:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Exercise 6:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Exercise 7:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Exercise 8:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Exercise 9:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Exercise 10:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox10" runat="server" Height="44px" Width="700px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="46px" OnClick="Button1_Click" Text="Submit" Width="199px" />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        </div>
        </form>
</body>
</html>
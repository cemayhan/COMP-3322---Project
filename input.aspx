<%@ Page Language="C#" AutoEventWireup="true" CodeFile="input.aspx.cs" Inherits="input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <style type="text/css">
        .auto-style2 {
            width: 870px;
            height: 351px;
        }
        .auto-style4 {
            text-align: left;
        }
        .auto-style5 {
            width: 434px;
            height: 454px;
        }
    </style>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
  <link rel="stylesheet" href="/resources/demos/style.css" />
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  
    <script src="js/datetimepicker_css.js"></script>
</head>
<body>
    <form id="form1" runat="server" accept-charset="utf-8">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large" Text="Please enter the words/sentences that students will work on as practice"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Unit Name =&nbsp;
        <asp:TextBox ID="TextBox11" runat="server" Height="30px" MaxLength="16" Width="215px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Due Date =
        <asp:TextBox ID="TextBox12" runat="server" Height="30px" MaxLength="16" Width="215px" TextMode="DateTime"></asp:TextBox>
        <img src="images/cal.gif" onclick="javascript:NewCssCal ('TextBox12','MMddyyyy','dropdown',true,'24',true)" style="cursor:pointer" />
        <br />
        <br />
        <table class="auto-style2" style="vertical-align: top; text-align: left; text-indent: 9px">
            <tr>
                <td class="auto-style5">
        <asp:Label ID="Label2" runat="server" Text="Exercise 1:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Exercise 2:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Exercise 3:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Exercise 4:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Exercise 5:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Height="44px" Width="350px"></asp:TextBox>
                </td>
                <td class="auto-style5">
        <asp:Label ID="Label7" runat="server" Text="Exercise 6:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Exercise 7:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox7" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Exercise 8:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox8" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Exercise 9:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox9" runat="server" Height="44px" Width="350px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label11" runat="server" Text="Exercise 10:"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox10" runat="server" Height="44px" Width="350px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="46px" OnClick="Button1_Click" Text="Submit" Width="199px" />
                </td>
            </tr>
        </table>
        
        </div>
        </form>
</body>
</html>
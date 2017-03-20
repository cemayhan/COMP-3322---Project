<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
    </style>
   
</head>
<body>
   
   
    <form id="form1" runat="server">
    <div>
    
        <strong>
        <br class="auto-style1" />
        <br class="auto-style1" />
        </strong><span class="auto-style1"><strong>&nbsp;&nbsp;&nbsp; REGISTRATION</strong></span><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="21px" Width="194px"></asp:TextBox>

        
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Username "></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="21px" Width="195px"></asp:TextBox>
        
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="21px" TextMode="Password" Width="195px"></asp:TextBox>
        
        
    
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="User Type "></asp:Label>
&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Height="30px" Width="124px">
            <asp:ListItem Selected="True" Value="1">Student</asp:ListItem>
            <asp:ListItem Value="2">Teacher</asp:ListItem>
            <asp:ListItem Value="3">Admin</asp:ListItem>
        </asp:DropDownList>
        
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="28px" Text="Sign Up" Width="101px" OnClick="Button1_Click1" />
        <br />

        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />

    
    </div>
    </form>
</body>
</html>

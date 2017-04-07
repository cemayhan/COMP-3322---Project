<%@ Page Language="C#" AutoEventWireup="true" CodeFile="passreminder.aspx.cs" Inherits="passwordreset" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
            <label>
              <strong><span class="auto-style2">Enter your email address</span></strong>
            </label>
            <asp:TextBox ID="email1" runat="server" type="email" autocomplete="off" Height="35px" Width="245px" />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="email1" ErrorMessage="E-mail Address is required!" ForeColor="Red" Display="Dynamic" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" BackColor="#CCFFFF" BorderColor="#333300" Font-Size="Large" ForeColor="#000099" Height="33px" Text="Submit" Width="86px" OnClick="Button1_Click" />
          </div>
    </form>
</body>
</html>

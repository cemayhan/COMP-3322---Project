<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
    
html { 
  background: url(http://localhost/turkish/images/yenibackground.jpg) repeat center center fixed; 
  background-size: cover;
}
        .auto-style1 {
            text-align: center;
        }
    </style>
    </head>
<body>
    <div class="auto-style1">
    <asp:Image ID="Image1" src="http://localhost/turkish/images/head.png" runat="server" />
    <form id="form1" runat="server">
        
           
            <asp:Label ID="Label1" runat="server" style="text-align: right;"></asp:Label>
            
    </form>


    <h1>Assignments:</h1>
    <br />
    <asp:Panel ID="Panel1" runat="server"></asp:Panel><br />
    </div>
</body>
</html>

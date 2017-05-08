<%@ Page Language="C#" AutoEventWireup="true" CodeFile="editor.aspx.cs" Inherits="editor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" href="images/favicon-32x32.png" type="image/png" sizes="32x32"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            font-size: xx-large;
            text-align: right;
        }
        .auto-style4 {
            font-size: xx-large;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <h1 class="auto-style2"><strong>TEACHERS PAGE</strong></h1>
        <p class="auto-style3">
            Welcome , Dear
            <asp:Label ID="Label1" runat="server" Text="teachername"></asp:Label>
        </p>
        <p class="auto-style4">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;</p>


        <p class='right'>&nbsp;</p>
<p class='wrong'>&nbsp;</p>
    
    </div>
    </form>
</body>
</html>

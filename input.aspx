<%@ Page Language="C#" AutoEventWireup="true" CodeFile="input.aspx.cs" Inherits="input" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>

    <script src="js/datetimepicker_css.js"></script>


    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>


</head>
<body>
    <form id="form1" runat="server" accept-charset="utf-8" autocomplete="off" onsubmit="return confirm('Are you sure?');">
        <div class="auto-style1">

            <div class="auto-style1">

            <asp:Label ID="Label1" runat="server" Style="font-size: xx-large" Text="Please enter the words/sentences that students will work on as practice"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <br />
            Unit Name =&nbsp;
        <asp:TextBox ID="UnitName" runat="server" Height="30px" MaxLength="16" Width="215px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Due Date =
        <asp:TextBox ID="DueDate" runat="server" Height="30px" MaxLength="16" Width="215px"></asp:TextBox>
            <img src="images/cal.gif" onclick="javascript:NewCssCal ('DueDate','MMddyyyy','dropdown',true,'24',true)" style="cursor: po
           
            <table class="auto-style2" style="vertical-align: top; text-align: left; text-indent: 2px">
                <tr>
                    <td class="auto-style8">
                <br />
                <br />
                <br />Total Question Number =&nbsp;
        <asp:TextBox ID="Q7" runat="server" Height="35px" Width="48px" BorderColor="Brown" TextMode="Number" Style="text-align: center;"></asp:TextBox>
                    
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    
                        <asp:Button ID="Button2" runat="server" Height="36px" OnClick="Sorular_Click" Text="Create" Width="90px" />
                    </td>
                </tr>
                </div>
                <asp:Table ID="sorutable" runat="server">

                </asp:Table>
                <div>
                    <br />
                    <br />
&nbsp;<asp:Button ID="Button1" runat="server" Height="46px" OnClick="Submit_Click" Text="Submit" Width="199px" />
                    </td>
                </tr>
            </table>

            </div>

        </div>
    </form>



</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="icon" href="images/favicon-32x32.png" type="image/png" sizes="32x32"/>
    <link rel="stylesheet" href="css/styler.css" type="text/css"/>
    <title></title>

   <script type="text/javascript">
       function Changeit() {
           document.getElementsByName('MainFrame')[0].src = 'study.aspx';           
       }
       function Changeit2() {
           document.getElementsByName('MainFrame')[0].src = 'media.aspx';
       }
       function Changeit3() {
           document.getElementsByName('MainFrame')[0].src = 'game.aspx';
       }
       function Changeit4() {
           document.getElementsByName('MainFrame')[0].src = 'stats.aspx';
       }
</script>

</head>
<body>
    <div id="wrapper">
    <form id="form1" runat="server">





        <table class="auto-style17">
            <tr>
                <td class="auto-style15"></td>
                <td class="auto-style16">
                    <asp:Image ID="Image1" src="/images/head.png" runat="server" Height="145px" ImageAlign="Top" Width="100%" /></td>
                <td style="line-height: 1px; padding: 1px; margin: 1px; vertical-align: bottom; text-align: left;">
                    <br />
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label12" runat="server"></asp:Label>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>

                </td>
            </tr>
        </table>




        <table border="0" class="auto-style2" draggable="false" style="border-style: none;">
            <tr>
                <td class="auto-style20" style="border-style: none;">
                <asp:Button CssClass="study" ID="study" runat="server" Text="Study Center" OnClick="study_Click" />
                </td>
                <td class="auto-style20" style="border-style: none;">
                    <asp:Button CssClass="media" ID="media" runat="server" Text="Media" OnClick="media_Click" />
                </td>
                <td class="auto-style20" style="border-style: none;">
                    <asp:Button CssClass="game" ID="game" runat="server" Text="Game &amp; Fun" OnClick="game_Click" />
                </td>
                <td class="auto-style20" style="border-style: none;">
                    <asp:Button CssClass="stats" ID="stats" runat="server" Text="Statistics" OnClick="stats_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="4" class="auto-style14" style="border: 0px none">
                      
                   <iframe id="MainFrame" class="auto-style12" draggable="false" runat="server"/> 
                   

                </td>
            </tr>
        </table>




        <asp:Table ID="table1" runat="server" />
        
    </form>
        
   </div>
    
</body>
</html>


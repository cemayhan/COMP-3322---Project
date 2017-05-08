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
           document.getElementsByName('MainFrame')[0].src = 'speakingtest.aspx';
       }
       function Changeit3() {
           document.getElementsByName('MainFrame')[0].src = 'practice.aspx';
       }
       function Changeit4() {
           document.getElementsByName('MainFrame')[0].src = 'stats.aspx';
       }
</script>

    <style type="text/css">
        
        .auto-style19 {
            width: 100%;
            height: 140px;
        }
        .auto-style20 {
            width: 15%;
            vertical-align: bottom;
            text-align: center;
        }
        .resim{
            width:85%;
            vertical-align:bottom;
        }
        .logininfo {
            width:10%;
            vertical-align:text-top;
            text-align:right;
            height:50px;
        }
        .auto-style21 {
            width: 10%;
            vertical-align: bottom;
            
            text-align: right;
            height: 101px;
        }
        .auto-style22 {
            width: 10%;
            vertical-align: text-top;
            text-align: right;
            height: 15px;
            overflow: visible;
        }
        .auto-style23 {
            width: 10%;
            vertical-align: text-top;
            text-align: right;
            height: 19px;
        }
    </style>

</head>
<body>
    <div id="wrapper" class="auto-style14">
    <form id="form1" runat="server">





        <table class="auto-style19">
            <tr>
                <td class="resim" rowspan="3">
                    <asp:Image ID="Image1" src="/images/header-tr.png" runat="server" Height="154px" Width="99%" BorderStyle="None" ImageAlign="AbsBottom"/>
                </td>
                    
                         
                <td class="auto-style21">
                    
                    <asp:Label ID="Label12" runat="server"></asp:Label></td>
                    
                         
            </tr>
            <tr>
                    
                         
                <td class="auto-style22" style="vertical-align: bottom; line-height: 3px;"><asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Logout</asp:LinkButton>
                   
                </td>
                    
                         
            </tr>
            <tr>
                    
                         
                <td class="auto-style23" style="vertical-align: bottom; line-height: 3px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;</td>
                    
                         
            </tr>
        </table>




        <table border="0" class="auto-style2" draggable="false" style="border-width: 0px; border-style: none; empty-cells: hide;">
            <tr>
                <td class="auto-style20" style="border-style: none;">
                <asp:Button CssClass="study" ID="study" runat="server" Text="Study Center" OnClick="study_Click" />
                </td>
                <td class="auto-style20" style="border-style: none;">
                    <asp:Button CssClass="media" ID="media" runat="server" Text="Chat" OnClick="media_Click" />
                </td>
                <td class="auto-style20" style="border-style: none;">
                    <asp:Button CssClass="game" ID="game" runat="server" Text="Practice" OnClick="game_Click" />
                </td>
                <td class="auto-style20" style="border-style: none;">
                    <asp:Button CssClass="stats" ID="stats" runat="server" Text="Statistics" OnClick="stats_Click" />
                </td>
            </tr>
            <tr id="trow">
                <td colspan="4" class="auto-style14" style="border: 0px none">
                      
                   <iframe id="MainFrame" class="auto-style12" draggable="false" runat="server" style="width:100%; border:0px;"/> 
                   

                </td>
               
            </tr>
        </table>




        <asp:Table ID="table1" runat="server" />
        
    </form>
        
   </div>
    <script>

    // get the width of the textarea minus scrollbar
var textareaWidth = document.getElementById("trow").scrollWidth;

// width of our wrapper equals width of the inner part of the textarea
        document.getElementById("wrapper").style.width = textareaWidth + "px";


    </script>
</body>
</html>


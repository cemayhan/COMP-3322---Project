<%@ Page Language="C#" AutoEventWireup="true" CodeFile="readnspeak.aspx.cs" Inherits="deney" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>


    <link rel="icon" href="images/favicon-32x32.png" type="image/png" sizes="32x32" />
    <meta http-equiv="Content-type" content="text/html; charset=UTF-8" />

    <title>Read & Speak Activity</title>

    <script type="text/javascript" src="/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="/dummy.js"></script>

    <script type='text/javascript'>//<![CDATA[
        window.onload = function () {
            $(function () {
                $("input:text").keypress(function (event) {
                    event.preventDefault();
                    return false;
                });
            });
        }//]]> 
    </script>
    <script type='text/javascript'>//<![CDATA[
        $(function () {
            $("input:text").bind("cut copy paste", function (e2) {
                e2.preventDefault();
            });
        });//]]> 

    </script>
   
    
   
    <style type="text/css">
        .auto-style6 {
            width: 805px;
            height: 289px;
        }

        .auto-style4 {
            font-size: medium;
            text-align: center;
            text-emphasis-position: below;
            vertical-align: middle;
            margin: auto;
            display: inline-block;
            vertical-align: central;
        }

        .auto-style7 {
            width: 791px;
            height: 312px;
            text-align: center;
            vertical-align: middle;
            margin: auto;
            display: inline-block;
            vertical-align: central;
        }

        .auto-style8 {
            text-align: center;
        }

        div > * {
            vertical-align: middle;
            // Align children to middle of line
        }
    </style>
    <style type="text/css">
        .modal {
            position: fixed;
            top: 0;
            left: 0;
            background-color: black;
            z-index: 99;
            opacity: 0.8;
            filter: alpha(opacity=80);
            -moz-opacity: 0.8;
            min-height: 100%;
            width: 100%;
        }

        .loading {
            font-family: Arial;
            font-size: 10pt;
            border: 5px solid #67CFF5;
            width: 200px;
            height: 135px;
            display: none;
            position: absolute;
            margin-left: auto;
            margin-right: auto;
            left: 50%;
            right: 50%;
            background-color: White;
            z-index: 999;
            margin-top: auto;
            margin-bottom: auto;
            top: 50%;
            bottom: 50%;
        }

        .auto-style15 {
            width: 100%;
            height: 329px;
            text-align: center;
            vertical-align: middle;
            margin: auto;
            display: inline-block;
            vertical-align: central;
        }

        .auto-style18 {
            width: 100%;
            height: 36px;
            text-align: center;
            vertical-align: middle;
            margin: auto;
            display: inline-block;
            vertical-align: central;
        }

        .auto-style19 {
            height: 174px;
        }
    </style>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
    <script type="text/javascript">
        function ShowProgress() {
            setTimeout(function () {
                var modal = $('<div />');
                modal.addClass("modal");
                $('body').append(modal);
                var loading = $(".loading");
                loading.show();
                var top = Math.max($(window).height() / 2 - loading[0].offsetHeight / 2, 0);
                var left = Math.max($(window).width() / 2 - loading[0].offsetWidth / 2, 0);
                loading.css({ top: top, left: left });
            }, 200);
        }
        $('form').live("submit", function () {
            ShowProgress();
        });
    </script>


</head>
<body style="background-color: #edffed">
    
   <form id="form2" runat="server" autocomplete="off" defaultbutton="ImageButton2">
        <div class="auto-style8">

            <div class="auto-style19">

                <asp:Label ID="Label2" runat="server"></asp:Label>
                <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
                <br />

                <asp:Image ID="Image1" runat="server" ImageUrl="~/images/header-tr.png" Height="154px" Width="811px" />
                <br />
                <br />

                <br />
            </div>
            <center>
        <table class="auto-style6" style="border: medium double #000080">
            <tr>
                <td class="auto-style18" style="border-style: none none double none; background-color: #CCFFFF; border-top-width: 0px; border-right-width: 0px; border-left-width: 0px; border-bottom-color: #0000FF;">
                    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Width="100%">
                    </asp:Table>
                </td>
            </tr>
            <tr>
                <td class="auto-style15" style="background-color: #CCFFFF">
        
                    <br /><br />
                    <asp:Label ID="Label3" runat="server" Text="Text to Read =&gt;"></asp:Label>
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="380px" CssClass="auto-style4" BorderColor="White" BorderStyle="Double"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br /> 
                    <br />
                        <asp:Label ID="Label4" runat="server" Text="Your Record =&gt; "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in German" BorderColor="#0000CC" BorderStyle="Double"></asp:TextBox>
                        &nbsp;
        <asp:Image ID="micimage" runat="server" onclick="startDictation1()" src="images/mic.png" height="50" width="50" style="vertical-align: middle" /><br /><br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:ImageButton ID="ImageButton2" runat="server" Height="63px" ImageUrl="~/images/submit2.png" Width="172px" OnClick="Check_Click" CssClass="auto-style7" />
                                       
                &nbsp;&nbsp;&nbsp; &nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="63px" ImageUrl="~/images/next.png" Width="172px" OnClick="Next_Click" CssClass="auto-style7" />
                                       
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                       
                </td>
            </tr>
        </table></center>


        </div>
        
        <asp:Label ID="Label6" runat="server" Visible="false"></asp:Label>
        
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="16px" Width="16px" placeholder="Press the Mic Button and Read the text above in German" BorderColor="#EDFFED" BorderStyle="None" BackColor="#EDFFED" BorderWidth="0px" Font-Size="0pt" ForeColor="#EDFFED"></asp:TextBox>
        
        <br />
        
        </form>

      <div class="loading" align="center">
            Loading. Please wait.
            <img src="images/loading.gif" alt="" />
        </div>

    <script>
        function startDictation1() {

            if (window.hasOwnProperty('webkitSpeechRecognition')) {

                var recognition = new webkitSpeechRecognition();

                recognition.continuous = false;
                recognition.interimResults = false;

                recognition.lang = "tr-TR";
                recognition.start();

                recognition.onresult = function (e) {
                    
                    document.getElementById('TextBox2').value = e.results[0][0].transcript;
                    document.getElementById('TextBox1').value = e.results[0][0].transcript;
                    recognition.stop();
                    document.getElementById('form2').submit();
                };

                recognition.onerror = function (e) {
                    recognition.stop();
                }
            }
             
        }
    </script>
    <script src='//vws.responsivevoice.com/v/e?key=Ve0mEYUy'></script>
</body>
</html>

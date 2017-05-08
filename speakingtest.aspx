<%@ Page Language="C#" AutoEventWireup="true" CodeFile="speakingtest.aspx.cs" Inherits="speakingtest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="icon" href="images/favicon-32x32.png" type="image/png" sizes="32x32" />
    <meta http-equiv="Content-type" content="text/html; charset=UTF-8" />
     <meta http-equiv="refresh" content="30"/>

    <title>Talking Talking ...</title>

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
        .auto-style1 {
            text-align: center;
        }

        .auto-style2 {
            height: 23px;
            width: 803px;
        }

        .auto-style3 {
            width: 55%;
            height: 251px;
        }

        .auto-style4 {
            width: 200px;
        }

        .auto-style5 {
            height: 23px;
        }
    </style>
</head>
<body style="background-color: #edffed">
    <form id="form1" runat="server" autocomplete="off">
        <div class="auto-style1">

            <asp:Image ID="Image1" runat="server" Height="154px" ImageUrl="~/images/header-tr.png" Width="811px" />

            <br />
            <center>
        <table class="auto-style3" style="border: 0px none #EDFFED">
            <tr>
                <td class="auto-style2" style="vertical-align: top; text-align: left; background-color: #CCFFFF;">
                    <div>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                        </div>
                </td>
                <td class="auto-style4" style="vertical-align: bottom; background-color: #CCFFFF;"><video width="200" height="100" autoplay="autoplay" loop>
<source src="records/hello.mp4" type="video/mp4" />
</video></td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="2" style="border: 0px none #CCFFFF; vertical-align: middle; text-align: center; background-color: #CCFFFF;">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    &nbsp;<br />
                    <br />
                    <asp:Label ID="Label2" runat="server">Your Message : </asp:Label>
                    &nbsp;&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="#000066" BorderStyle="None" BorderWidth="0px" ForeColor="#FFFF99" Height="50px" Width="574px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Image ID="Image2" runat="server" Height="50px" ImageUrl="~/images/mic.png" Width="50px" AlternateText="Record" BorderColor="#CCFFFF" BorderStyle="None" BorderWidth="0px" ImageAlign="Middle" onclick="startDictation1()" />
                    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Image ID="Image3" runat="server" Height="50px" ImageUrl="~/images/refresh.png" Width="50px" AlternateText="Record" BorderColor="#CCFFFF" BorderStyle="None" BorderWidth="0px" ImageAlign="Middle" onclick="myFunction()" />

                    &nbsp;
                    <br />
                    <br />
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/submit2.png" OnClick="ImageButton1_Click" />
                </td>
            </tr>
        </table>
            </center>

            <br />

        </div>
    </form>
    <script>
        function startDictation1() {

            if (window.hasOwnProperty('webkitSpeechRecognition')) {

                var recognition = new webkitSpeechRecognition();

                recognition.continuous = false;
                recognition.interimResults = false;

                recognition.lang = "tr-TR";
                recognition.start();

                recognition.onresult = function (e) {

                    document.getElementById('TextBox1').value = e.results[0][0].transcript;
                    recognition.stop();
                    document.getElementById('form1').submit();
                };

                recognition.onerror = function (e) {
                    recognition.stop();
                }
            }

        }
    </script>
    <script>
        function myFunction() {
            location.reload();
        }
</script>
</body>
</html>

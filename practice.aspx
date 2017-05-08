<%@ Page Language="C#" AutoEventWireup="true" CodeFile="practice.aspx.cs" Inherits="practice" %>

<html>
    <head>
    <link rel="icon" href="images/favicon-32x32.png" type="image/png" sizes="32x32" />
    <meta http-equiv="Content-type" content="text/html; charset=UTF-8" />
    

    <title>Talking Talking ...</title>

    <script type="text/javascript" src="/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="/jquery-1.9.1.js"></script>
    <script type="text/javascript" src="/dummy.js"></script>
   
        <style type="text/css">
            .auto-style1 {
                height: 94px;
                width: 95px;
            }
            .auto-style2 {
                height: 95px;
                width: 89px;
            }
            .auto-style3 {
                height: 89px;
                width: 87px;
            }
        </style>
    </head>
<body>

<form id="form2" runat="server">
    
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Practice Area" style="font-size: x-large"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <br />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="http://turkish.typeit.org/">Turkish Keyboard</asp:HyperLink>
    <br />
    <asp:Image ID="Image1" runat="server" src="images/okuma-metinleri1.jpg" Height="427px" Width="934px" ImageUrl="~/images/okuma-metinleri1.jpg" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server"></asp:Label>
    <p style="height: 304px">
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" BackColor="#000066" BorderColor="Maroon" BorderWidth="4px" Font-Names="Comic Sans MS" Font-Size="Medium" ForeColor="#99FFCC" Height="277px" Width="862px" TextMode="MultiLine"/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img onclick="startDictation1()" src="images/mic.png" style="vertical-align:middle; " class="auto-style1" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
        <asp:Image ID="Image2" runat="server" src="images/okuma-metinleri2.jpg" Height="424px" Width="973px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server"></asp:Label>
    <p style="height: 304px">
        &nbsp;<asp:TextBox ID="TextBox2" runat="server" BackColor="#000066" BorderColor="Maroon" BorderWidth="4px" Font-Names="Comic Sans MS" Font-Size="Medium" ForeColor="#99FFCC" Height="277px" Width="862px" TextMode="MultiLine" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img onclick="startDictation2()" src="images/mic.png" style="vertical-align:middle; " class="auto-style2" /></p>
        <asp:Image ID="Image3" runat="server" src="images/okuma-metinleri3.jpg" Height="441px" Width="982px" />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server"></asp:Label>
    <p style="height: 304px">
        &nbsp;<asp:TextBox ID="TextBox3" runat="server" BackColor="#000066" BorderColor="Maroon" BorderWidth="4px" Font-Names="Comic Sans MS" Font-Size="Medium" ForeColor="#99FFCC" Height="277px" Width="862px" TextMode="MultiLine" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<img onclick="startDictation3()" src="images/mic.png" style="vertical-align:middle; " class="auto-style3" /></p>
    <p style="height: 304px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="47px" Text="Submit" Width="167px" OnClick="Button1_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
        </div>
</form>
    <script>
        function startDictation1() {

            if (window.hasOwnProperty('webkitSpeechRecognition')) {

                var recognition = new webkitSpeechRecognition();

                recognition.continuous = true;
                recognition.interimResults = true;

                recognition.lang = "tr-TR";
                recognition.start();

                recognition.onresult = function (e) {

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
    <script>
        function startDictation2() {

            if (window.hasOwnProperty('webkitSpeechRecognition')) {

                var recognition = new webkitSpeechRecognition();

                recognition.continuous = true;
                recognition.interimResults = true;

                recognition.lang = "tr-TR";
                recognition.start();

                recognition.onresult = function (e) {

                    document.getElementById('TextBox2').value = e.results[0][0].transcript;
                    recognition.stop();
                    document.getElementById('form2').submit();
                };

                recognition.onerror = function (e) {
                    recognition.stop();
                }
            }

        }
    </script>
    <script>
        function startDictation3() {

            if (window.hasOwnProperty('webkitSpeechRecognition')) {

                var recognition = new webkitSpeechRecognition();

                recognition.continuous = true;
                recognition.interimResults = true;

                recognition.lang = "tr-TR";
                recognition.start();

                recognition.onresult = function (e) {

                    document.getElementById('TextBox3').value = e.results[0][0].transcript;
                    recognition.stop();
                    document.getElementById('form2').submit();
                };

                recognition.onerror = function (e) {
                    recognition.stop();
                }
            }

        }
    </script>

   
    </body></html>

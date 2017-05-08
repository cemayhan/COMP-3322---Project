<%@ Page Language="C#" AutoEventWireup="true" CodeFile="speaking.aspx.cs" Inherits="speaking" %>

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

        </style>
</head>
<body style="background-color: #edffed">
    <form id="form1" runat="server" autocomplete="off">
        <div class="auto-style1">

            <asp:Image ID="Image1" runat="server" Height="154px" ImageUrl="~/images/header-tr.png" Width="811px" />

        </div>
        <div>

            The Scenario: Interview</div>
        <div>

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
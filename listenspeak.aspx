﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="listenspeak.aspx.cs" Inherits="listenspeak" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 943px;
            text-align: center;
            height: 189px;
        }

        .auto-style2 {
            width: 989px;
            height: 913px;
        }

        .auto-style5 {
            width: 1028px;
            height: 923px;
        }

        .auto-style8 {
            width: 509px;
            text-align: center;
            height: 144px;
        }

        .auto-style9 {
            width: 510px;
            text-align: center;
            height: 144px;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            text-align: center;
            height: 144px;
        }
    </style>
</head>
<body>
    <div class="auto-style10">
    <form id="form1" runat="server">
        <div class="auto-style5">

            <table align="center" class="auto-style2">
                <tr>
                    <td class="auto-style1" colspan="2">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/head.PNG" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton1_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation1()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox1" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton2_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation2()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox2" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton3_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation3()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox3" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton4_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation4()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox4" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton5_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation5()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox5" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton6_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation6()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox6" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label6" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton7" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton7_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation7()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox7" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label7" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton8" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton8_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation8()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox8" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label8" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton9" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton9_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation9()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox9" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label9" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton10" runat="server" Height="50px" ImageUrl="~/images/play.png" OnClick="ImageButton10_Click" Width="50px" />
                        &nbsp;&nbsp;
                   <img onclick="startDictation10()" src="images/mic.png" height="50" width="50" />
                        <br />
                        Your Record =&nbsp;
                    <asp:TextBox ID="TextBox10" runat="server" Height="39px" Width="345px" AutoCompleteType="Disabled" placeholder="Press the Mic Button and Speak the text you heard"></asp:TextBox>
                        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="Label10" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11" colspan="2">
                        <asp:Label ID="Label11" runat="server"></asp:Label>
                        <br />
                        <asp:ImageButton ID="ImageButton11" runat="server" ImageUrl="~/images/submit.png" OnClick="ImageButton11_Click" />
                    </td>
                </tr>
            </table>


        </div>
    </form>
    <script type="text/javascript">
                            $(document).ready(function () {
                                $('#ImageButton1').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation1() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox1').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
        }
                            $(document).ready(function () {
                                $('#ImageButton2').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation2() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox2').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton3').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation3() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox3').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton4').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation4() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox4').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton5').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation5() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox5').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton6').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation6() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox6').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton7').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation7() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox7').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton8').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation8() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox8').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton9').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation9() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox9').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }
                            $(document).ready(function () {
                                $('#ImageButton10').click();
                                mediaStream.getAudioTracks()[0].enabled = false;

                                var start = new Date().getTime();
                                var end = start;
                                while (end < start + 7000) {
                                    end = new Date().getTime();
                                }
                                mediaStream.getAudioTracks()[0].enabled = true;
                            });

                            function startDictation10() {

                                if (window.hasOwnProperty('webkitSpeechRecognition')) {

                                    var recognition = new webkitSpeechRecognition();

                                    recognition.continuous = false;
                                    recognition.interimResults = false;

                                    recognition.lang = "tr-TR";
                                    recognition.start();

                                    recognition.onresult = function (e) {
                                        document.getElementById('TextBox10').value
                                            = e.results[0][0].transcript;
                                        recognition.stop();
                                        document.getElementById('form1').submit();
                                    };

                                    recognition.onerror = function (e) {
                                        recognition.stop();
                                    }

                                }
                            }

    </script>


    </div>


</body>
</html>

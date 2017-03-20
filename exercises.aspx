
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="exercises.aspx.cs" Inherits="exercises" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script type="text/javascript" src="/dummy.js"></script>
    <script type="text/javascript" src="/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="/jquery-1.9.1.js"></script>

    <script type='text/javascript'>//<![CDATA[
window.onload=function(){
 $(function() {
     $("input:text").keypress(function (event) {
          event.preventDefault();
         return false;
     });
});
}//]]> 
</script>
<script type='text/javascript'>//<![CDATA[
$(function(){
 $("input:text").bind("cut copy paste",function(e2) {
          e2.preventDefault();
      });
});//]]> 

</script>

    <style>
    
html { 
  background: url(/images/exercisebackground.jpg) no-repeat center center fixed; 
  background-size: cover;
}
        .auto-style4 {
            font-size: medium;
        }
        .auto-style5 {
            width: 607px;
        }
        .auto-style6 {
            width: 602px;
        }
        </style>
    <meta http-equiv="Content-type" content="text/html; charset=utf-8" />

</head>
    
<body>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Image ID="Image1" src="/images/head.png" runat="server" />
    <form id="form1" runat="server" accept-charset="utf-8">
        <div>
            <table runat="server">
                <tr>
                    <td class="auto-style5">Text to Read =&gt;
        <asp:Label ID="Label1" runat="server" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px" CssClass="auto-style4"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox1" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation1()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                    <td class="auto-style6">Text to Read =&gt;
        <asp:Label ID="Label2" runat="server" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox2" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation2()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                  </tr>
                <tr>
                    <td class="auto-style5">Text to Read =&gt;
        <asp:Label ID="Label3" runat="server" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox3" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation3()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                    <td class="auto-style6">Text to Read =&gt;
        <asp:Label ID="Label4" runat="server" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox4" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation4()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                </tr>
                <tr>
                    <td class="auto-style5">Text to Read =&gt;
        <asp:Label ID="Label5" runat="server" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox5" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation5()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                    <td class="auto-style6">Text to Read =&gt;
        <asp:Label ID="Label6" runat="server" Text="" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox6" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation6()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                </tr>
                <tr>
                    <td class="auto-style5">Text to Read =&gt;
        <asp:Label ID="Label7" runat="server" Text="" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox7" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation7()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                    <td class="auto-style6">Text to Read =&gt;
        <asp:Label ID="Label8" runat="server" Text="" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox8" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation8()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                </tr>
                <tr>
                    <td class="auto-style5">Text to Read =&gt;
        <asp:Label ID="Label9" runat="server" Text="" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox9" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation9()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                    <td class="auto-style6">Text to Read =&gt;
        <asp:Label ID="Label10" runat="server" Text="" Value="" BackColor="DarkBlue" ForeColor="White" Height="64px" Width="388px"></asp:Label>
        <br />
        Your Record =&gt;
        <asp:TextBox ID="TextBox10" runat="server" Height="64px" Width="380px" placeholder="Press the Mic Button and Read the text above in Turkish"></asp:TextBox>
        &nbsp;
        <img onclick="startDictation10()" src="/images/mic.png" height="50" width="50" style="vertical-align:middle" /></td>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="X-Large"></asp:Label>
                    </th>
                </tr>
                <tr>
                    <th colspan="2">
                        <asp:ImageButton ID="Button1" OnClick="Button1_Click1" ImageUrl="/images/submit.png" Width="150px" Height="60px" runat="server"/>
                    </th>
                </tr>
            </table>
        </div>
    </form>


<!-- HTML5 Speech Recognition API -->
<script>
  function startDictation1() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox1').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

    <script>
  function startDictation2() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox2').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation3() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox3').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation4() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox4').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation5() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox5').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation6() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox6').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation7() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox7').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation8() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox8').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation9() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox9').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>

     <script>
  function startDictation10() {

    if (window.hasOwnProperty('webkitSpeechRecognition')) {

      var recognition = new webkitSpeechRecognition();

      recognition.continuous = false;
      recognition.interimResults = false;

      recognition.lang = "de-DE";
      recognition.start();

      recognition.onresult = function(e) {
          document.getElementById('TextBox10').value
                                 = e.results[0][0].transcript;
        recognition.stop();
        document.getElementById('form1').submit();
      };

      recognition.onerror = function(e) {
        recognition.stop();
      }

    }
  }
</script>
</body>
</html>
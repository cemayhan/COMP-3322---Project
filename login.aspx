﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="register" %>
<!DOCTYPE html>
<html>
<head>
    
<link rel="icon" href="images/favicon-32x32.png" type="image/png" sizes="32x32"/>
<meta name="theme-color" content="#ffffff" charset="UTF-8" >
    
    <title>Sign-Up/Login Form</title>
    <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">


    <link rel="stylesheet" href="css/style.css">
</head>

<body>
    <form id="form1" runat="server" defaultbutton="Button1">
        <center><br /><br /><asp:Label ID="errormessage" runat="server" /></center>
      
        <div class="form">

            <ul class="tab-group">
                <li class="tab" ><a href="#signup">Sign Up</a></li>
                <li class="tab active "><a href="#login">Log In</a></li>
            </ul>

            <div class="tab-content">
                <div id="signup">
                    
                     <div class="top-row">
                        <div class="field-wrap">
                            <label>
                                First Name<span class="req">*</span>
                            </label>
                            <asp:TextBox ID="firstname" runat="server" autocomplete="off" type="text" />
                        </div>

                        <div class="field-wrap">
                            <label>
                                Last Name<span class="req">*</span>
                            </label>
                            <asp:TextBox ID="lastname" runat="server" type="text" autocomplete="off" />
                        </div>
                    </div>

                    <div class="field-wrap">
                        <label>
                            Email Address<span class="req">*</span>
                        </label>
                        <asp:TextBox ID="email1" runat="server" type="email" autocomplete="off" />
                        
                    </div>
                    <div class="field-wrap">
                        <label>
                            Username<span class="req">*</span>
                        </label>
                        <asp:TextBox ID="username" runat="server" type="text" autocomplete="off" />
                        <asp:Label ID="wrongemail" runat="server" />
                    </div>

                    <div class="field-wrap">
                        <label>
                            Set A Password<span class="req">*</span>
                        </label>
                        <asp:TextBox ID="password" runat="server" type="password" autocomplete="off" />
                    </div>

                    <div class="field-wrap">
                        <label>
                            Confirm Password<span class="req">*</span>
                        </label>
                        <asp:TextBox ID="passwordcheck" runat="server" type="password" autocomplete="off" />
                    </div>

                    <asp:Button ID="Register1" runat="server" class="button button-block" Text="Get Started" OnClick="Register1_Click1" />

                   

                </div>

                <div id="login">
                    <h1>Welcome Back!</h1>
                    
                    <asp:Label ID="answerback" runat="server" />
                    <div class="field-wrap">
                        <label>
                            Username<span class="req">*</span>
                        </label>
                        <asp:TextBox ID="email2" runat="server" type="text" autocomplete="off" />
                    </div>

                    <div class="field-wrap">
                        <label>
                            Password<span class="req">*</span>
                        </label>
                        <asp:TextBox ID="password2" runat="server" type="password" autocomplete="off" />
                    </div>

                    <p class="forgot"><a href="javascript:window.open('passreminder.aspx','Password Reminder','width=45%,height=45%','scrollbars=no','resizable=no')" style="float: right;">Forgot Password?</a></p>

                    <asp:Button ID="Button1" runat="server" class="button button-block" Text="Log In" OnClick="Login1_Click1" />

                    

                </div>

            </div>
            <!-- tab-content -->

        </div>
        <!-- /form -->
    </form>
   
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src="js/index.js"></script>
   
</body>
</html>

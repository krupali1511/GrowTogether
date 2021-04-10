<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactAdmin.aspx.cs" Inherits="GrowTogetherClient.ContactAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
     <style>
        body {
            font-family: Arial, Helvetica, sans-serif;
        }
        form {
            border: 3px solid #f1f1f1;
        }
        input[type=text], input[type=password] {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            box-sizing: border-box;
        }
        button:hover {
            opacity: 0.8;
        }
        .cnbtn {
            background-color: #ec3f3f;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 49%;
        }
        .lgnbtn {
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            cursor: pointer;
            width: 50%;
        }
        .imgcontainer {
            text-align: center;
            margin: 24px 0 12px 0;
        }
        img.avatar {
            width: 40%;
            border-radius: 50%;
        }
        .container {
            padding: 16px;
            height: 326px;
        }
        span.psw {
            float: right;
            padding-top: 16px;
        }
        /* Change styles for span and cancel button on extra small screens */
        @media screen and (max-width: 300px) {
            span.psw {
                display: block;
                float: none;
            }
            .cnbtn {
                width: 100%;
            }
        }
        .frmalg {
            margin: auto;
            width: 40%;
        }
    </style>

<body>
     <nav class="navbar navbar-inverse">
  <div class="container-fluid">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">GrowTogether</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="/Fileupload.aspx" onclick="home">Home</a></li>
      <li><a href="/ContactAdmin.aspx" onclick="contacthome">Contact Admin</a></li>
      <li><a href="#" onclick="about">About</a></li>
      <li><a href="/Profile.aspx" onclick="profile">Profile</a></li>
    </ul>
  </div>
</nav>
    <form id="form1" runat="server">
        <div class="container">
            <center>
                <h3>Send message to admin</h3>
            </center>
            <label for="uname"><b>Message Subject</b></label>
            <asp:TextBox runat="server" ID="msgsub" placeholder="Subject"></asp:TextBox>

            <label for="psw"><b>
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            Message Description </b></label>
&nbsp;<asp:TextBox runat="server" ID="msgdes"  placeholder="Message" ></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Button runat="server" ID="btn_Login" CssClass="lgnbtn" Text="Send" OnClientClick="loginClick" OnClick="btn_Message_Click" />
            <br />

            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

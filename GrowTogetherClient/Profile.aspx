<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="GrowTogetherClient.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <style>
        @import url("https://fonts.googleapis.com/css2?family=Poppins:weight@100;200;300;400;500;600;700;800&display=swap");

        body {
            font-family: "Poppins", sans-serif;
            font-weight: 300
        }

        .card {
            padding: 10px;
            border: none
        }

        .height {
            height: 100vh
        }

        .inputs span {
            font-size: 13px;
            font-weight: 600;
            color: #9e9e9e
        }

        .inputs input {
            height: 48px;
            border: 2px solid #9e9e9e
        }

            .inputs input:focus {
                border: 2px solid blue;
                box-shadow: none
            }

        label.radio {
            cursor: pointer;
            width: 100%
        }

            label.radio input {
                position: absolute;
                top: 0;
                left: 0;
                visibility: hidden;
                pointer-events: none
            }

            label.radio span {
                padding: 7px 14px;
                border: 2px solid blue;
                display: inline-block;
                color: blue;
                border-radius: 3px;
                text-transform: uppercase;
                width: 100%;
                height: 49px;
                display: flex;
                justify-content: start;
                align-items: center
            }

            label.radio input:checked + span {
                border-color: blue;
                background-color: blue;
                color: #fff;
                width: 100%;
                height: 49px;
                display: flex;
                justify-content: start;
                align-items: center
            }

        .name {
            font-size: 13px;
            font-weight: 600;
            color: #9e9e9e;
            margin-left: 3px
        }

        .options {
            text-decoration: none
        }

        .btn-outline-primary {
            color: #0000ff;
            border-color: #0000ff
        }

            .btn-outline-primary:hover {
                background-color: #0000ff;
                border-color: #0000ff
            }
    </style>
</head>
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
            <div class="row height d-flex justify-content-center align-items-center">
                <div class="col-md-8">
                    <div class="card py-5">
                        <div class="inputs px-4">
                            <span class="text-uppercase">Username</span>
                            <asp:TextBox runat="server" ID="txt_Username" class="form-control" />
                        </div>
                        <div class="inputs px-4">
                            <span class="text-uppercase">Name</span>
                            <asp:TextBox runat="server" ID="txt_name" class="form-control" />
                        </div>
                        <div class="row mt-3 g-2">
                            <div class="col-md-6">
                                <div class="inputs px-4">
                                    <span class="text-uppercase">Email</span>
                                    <asp:TextBox runat="server" ID="email" class="form-control" />
                                </div>
                            </div>
                            <div class="col-md-6">
                                <div class="inputs px-4">
                                    <span class="text-uppercase">Phone</span>
                                    <asp:TextBox runat="server" ID="phone" class="form-control" />
                                </div>
                            </div>
                        </div>
                        <div class="row mt-3 g-2">
                            <div class="inputs px-4">
                                <span class="text-uppercase">Gender</span>
                                <asp:RadioButtonList ID="gender"  runat="server">
                                    <asp:ListItem Text="Male" Value="Male" />
                                    <asp:ListItem Text="Female" Value="Female" />
                                    <asp:ListItem Text="Other" Value="Other" />
                                </asp:RadioButtonList>

                            </div>
                            <div class="mt-3 px-4">
                                <div class="d-flex flex-row align-items-center mt-4">
                                    <div class="ml-3">
                                        <asp:Button runat="server" Text="Update Profile" ID="Button1" OnClick="Button1_Click" class="btn btn-outline-primary" />
                                        <asp:Label ID="Label1" runat="server"  ></asp:Label>
                                    </div>
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
    </form>
</body>
</html>

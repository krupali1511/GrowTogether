<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="GrowTogetherClient.AdminHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HomeAdmin</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>

<style>
    .vertical-center {
        margin: 0;
        position: absolute;
        top: 50%;
        -ms-transform: translateY(-50%);
        transform: translateY(-50%);
    }

    .card {
        /* Add shadows to create the "card" effect */
        box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        transition: 0.3s;
        height: 100px;
    }

        /* On mouse-over, add a deeper shadow */
        .card:hover {
            box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);
        }

    /* Add some padding inside the card container */
    .container {
        padding: 2px 16px;
    }

    * {
        box-sizing: border-box;
    }

    /* Create three equal columns that floats next to each other */
    .column {
        float: left;
        width: 33.33%;
        padding: 10px;
        height: 300px; /* Should be removed. Only for demonstration */
    }

    /* Clear floats after the columns */
    .row:after {
        content: "";
        display: table;
        clear: both;
    }
</style>
<body>
    <form id="form1" runat="server" class="align-middle">

        <div class="row">
            <div class="column">
                <a href="/ManageUserClient.aspx">

                    <div class="card">
                        <div class="container">
                            <h4><b>Manage Users</b></h4>

                        </div>
                    </div>
                </a>
            </div>
            <div class="column">
                <a href="/ManageClass.aspx">

                    <div class="card">
                        <div class="container">
                            <h4><b>Manage Classes</b></h4>

                        </div>
                    </div>
                </a>
            </div>
            <div class="column">
                <a href="/UserSuggestion.aspx">

                    <div class="card">
                        <div class="container">
                            <h4><b>User suggestions</b></h4>

                        </div>
                    </div>
                </a>
            </div>
        </div>
        </div>
    </form>
</body>
</html>

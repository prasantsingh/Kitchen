<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Kojin.Customer.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Depo Login</title>
    <!-- BOOTSTRAP STYLES-->
    <link href="assets/css/bootstrap.css" rel="stylesheet" />
    <!-- FONTAWESOME STYLES-->
    <link href="assets/css/font-awesome.css" rel="stylesheet" />
    <!-- CUSTOM STYLES-->
    <link href="assets/css/custom.css" rel="stylesheet" />
    <!-- GOOGLE FONTS-->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css' />
</head>
<body>
   <form id="form1" runat="server">
        <div class="container">
            <div class="row text-center ">
                <div class="col-md-12">
                    <br />
                    <br />
                    <h2>Customer : Login</h2>

                    <h5>( Login yourself to get access )</h5>
                    <br />
                </div>
            </div>
            <div class="row ">

                <div class="col-md-4 col-md-offset-4 col-sm-6 col-sm-offset-3 col-xs-10 col-xs-offset-1">
                    <div class="panel panel-default">
                        <div class="panel-heading">
                            <strong>Enter Details To Login </strong>
                        </div>
                        <div class="panel-body">
                            <form role="form">
                                <br />
                                <div class="form-group input-group">
                                    <span class="input-group-addon"><i class="fa fa-tag"></i></span>
                                    <asp:TextBox ID="txtLoginId" runat="server" class="form-control" placeholder="Your Username " ></asp:TextBox>                                    
                                </div>
                                <div class="form-group input-group">
                                    <span class="input-group-addon"><i class="fa fa-lock"></i></span>
                                    <asp:TextBox ID="txtPassword" runat="server" class="form-control" placeholder="Your Password" TextMode="Password" ></asp:TextBox>                                 
                                </div>
                                <div class="form-group">
                                    <label class="checkbox-inline">
                                        <input type="checkbox" />
                                        Remember me
                                    </label>
                                    <span class="pull-right">
                                        <%--<a href="#">Forget password ? </a>--%>
                                    </span>
                                </div>
                                <div>
                                    <asp:Label ID="msg" runat="server" ForeColor="Red" Font-Size="Small" Text="Invalid username and password !!!"></asp:Label>
                                </div>
                                <asp:Button ID="btnLogin" runat="server" class="btn btn-primary " Text ="Login Now" OnClick="btnLogin_Click" />
                                    
                            </form>
                        </div>

                    </div>
                </div>


            </div>
        </div>


        <!-- SCRIPTS -AT THE BOTOM TO REDUCE THE LOAD TIME-->
        <!-- JQUERY SCRIPTS -->
        <script src="assets/js/jquery-1.10.2.js"></script>
        <!-- BOOTSTRAP SCRIPTS -->
        <script src="assets/js/bootstrap.min.js"></script>
        <!-- METISMENU SCRIPTS -->
        <script src="assets/js/jquery.metisMenu.js"></script>
        <!-- CUSTOM SCRIPTS -->
        <script src="assets/js/custom.js"></script>
    </form>
</body>
</html>

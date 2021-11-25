<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistro.aspx.cs" Inherits="AppEcologiaHumana.Paginas.frmRegistro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Ecología humana</title>
    <link rel="stylesheet" href="../assets/css/style.css">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="keywords" content="bootstrap, mobile template, cordova, phonegap, mobile, html, responsive" />
    <link rel="apple-touch-icon" sizes="180x180" href="assets/img/apple-touch-icon.png">
    <link rel="icon" type="image/png" href="../assets/img/favicon.png" sizes="32x32">
    <link rel="shortcut icon" href="assets/img/favicon.png">
    <script type="module" src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.esm.js"></script>
    <script nomodule src="https://unpkg.com/ionicons@5.5.2/dist/ionicons/ionicons.js"></script>
</head>
<body class="bg-light">
    <form id="form1" runat="server">

        <!-- loader -->
        <div id="loader">
            <img src="../assets/img/logo-icon.png" alt="icon" class="loading-icon">
        </div>
        <!-- * loader -->

        <!-- App Header -->
        <div class="appHeader no-border">
            <div class="left">
                <a href="javascript:;" class="headerButton goBack">
                    <ion-icon name="chevron-back-outline"></ion-icon>
                </a>
            </div>
            <div class="pageTitle"></div>
        </div>
        <!-- * App Header -->

        <!-- App Capsule -->
        <div id="appCapsule">

            <div class="section mt-2 text-center">
                <h1><i>Ecología Humana</i></h1>
                <h4>Crear cuenta con correo electrónico</h4>
            </div>
            <div class="section mt-2 mb-5 p-3">
                <div class="form-group basic">
                    <div class="input-wrapper">
                        <label class="label" for="lblEmail1">Correo electrónico</label>
                        <input type="email" class="form-control" runat="server" id="lblEmail1" placeholder="Correo electrónico">
                        <i class="clear-input">
                            <ion-icon name="close-circle"></ion-icon>
                        </i>
                    </div>
                </div>

                <div class="form-group basic">
                    <div class="input-wrapper">
                        <label class="label" for="lblPassword1">Contraseña</label>
                        <input type="password" runat="server" class="form-control" id="lblPassword1" placeholder="Contraseña">
                        <i class="clear-input">
                            <ion-icon name="close-circle"></ion-icon>
                        </i>
                    </div>
                </div>

                <div class="form-group basic">
                    <div class="input-wrapper">
                        <label class="label" for="lblPassword2">Confimar contraseña</label>
                        <input type="password" runat="server" class="form-control" id="lblPassword2" placeholder="Confimar contraseña">
                        <i class="clear-input">
                            <ion-icon name="close-circle"></ion-icon>
                        </i>
                    </div>
                </div>

                <div class="form-button-group">
                    <button type="submit" runat="server" id="btnCrear" onserverclick="btnCrear_ServerClick" class="btn btn-primary btn-block btn-lg">Crear cuenta</button>
                    <label class="label" runat="server" visible="false" style="color: red;" id="lblMensaje"></label>
                </div>

            </div>

        </div>
        <!-- * App Capsule -->



        <!-- ///////////// Js Files ////////////////////  -->
        <!-- Jquery -->
        <script src="<%= HttpContext.Current.Request.ApplicationPath %>assets/js/lib/jquery-3.4.1.min.js"></script>
        <!-- Bootstrap-->
        <script src="<%= HttpContext.Current.Request.ApplicationPath %>assets/js/lib/popper.min.js"></script>
        <script src="<%= HttpContext.Current.Request.ApplicationPath %>assets/js/lib/bootstrap.min.js"></script>
        <!-- Ionicons -->
        <!--<script src="<%= HttpContext.Current.Request.ApplicationPath %>ionicons-5.0.0/dist/ionicons.js"></script>-->
        <!-- Owl Carousel -->
        <script src="<%= HttpContext.Current.Request.ApplicationPath %>assets/js/plugins/owl-carousel/owl.carousel.min.js"></script>
        <!-- Base Js File -->
        <script src="<%= HttpContext.Current.Request.ApplicationPath %>assets/js/base.js"></script>
    </form>
</body>
</html>

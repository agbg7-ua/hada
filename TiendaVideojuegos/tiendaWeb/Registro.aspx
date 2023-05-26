<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="tiendaWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <link rel="stylesheet" type="text/css" href="styles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Inicio sesión/Registro </p>
    </div>

     <div class="container" style="width: 50%; float:left; height:900px;">
        <h3 style="text-align:center; margin-top:20px">Inicia sesión</h3><br />
         <asp:Panel runat="server" ID="loginvalidation" DefaultButton="iniciabutton">
             <div class="form-floating mb-3">
                 <asp:TextBox runat="server" ID="username1" TextMode="SingleLine" CssClass="form-control" ValidationGroup="login"></asp:TextBox>
                 <label for="username1">Username</label>
                 <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="username1vacio" runat="server" ControlToValidate="username1" ErrorMessage="Username es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="login"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="username1" ErrorMessage="Username no debe superar los 30 caracteres" ValidationExpression="[a-zA-Z0-9' ']{1,30}$" ValidationGroup="login"></asp:RegularExpressionValidator>
                 </div>
             </div>
             <div class="form-floating mb-3">
                 <asp:TextBox runat="server" ID="password1" TextMode="Password" CssClass="form-control" ValidationGroup="login"></asp:TextBox>
                 <label for="password1">Contraseña</label>
                 <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="password1vacio" runat="server" ControlToValidate="password1" ErrorMessage="Contraseña es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="login"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="password1" ErrorMessage="Contraseña no debe superar los 30 caracteres" ValidationExpression="[a-zA-Z0-9]{1,30}$" ValidationGroup="login"></asp:RegularExpressionValidator>
                 </div>
             </div>
            <asp:Button class="regbutton" ID="iniciabutton" runat="server" Text="Iniciar sesión" OnClick="Button1_Click"  ValidationGroup="login"/>
            <div class="container-fluid align-content-center" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
                <div class="alert alert-danger" role="alert" id="alerta1" runat="server" >
                    <p class="message">
                        <asp:Label ID="Msg" runat="server" ></asp:Label>
                        <asp:ValidationSummary ID="ValidationS" runat="server" DisplayMode="BulletList" font-size="Small" ValidationGroup="login"/>
                    </p>
                </div>
            </div>
        </asp:Panel>
     </div>
     <div class="container" style="width: 50%; float:right; height: 900px">
        <h3 style="text-align: center;margin-top:20px">Regístrate</h3><br />
        <asp:Panel runat="server" ID="signupvalidation" DefaultButton="registbutton">
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="nombre" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="nombre">Nombre</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="nombrevacio" runat="server" ControlToValidate="nombre" ErrorMessage="Nombre es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <%--<asp:RegularExpressionValidator runat="server" ControlToValidate="username1" ErrorMessage="Nombre no debe superar los 30 caracteres" ValidationExpression="[a-zA-Z' ']{1,30}$" ValidationGroup="signup"></asp:RegularExpressionValidator>--%>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="apellidos" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="apellidos">Apellidos</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="apellidosvacio" runat="server" ControlToValidate="apellidos" ErrorMessage="Apellidos es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <%--<asp:RegularExpressionValidator runat="server" ControlToValidate="username1" ErrorMessage="Apellidos no debe superar los 30 caracteres" ValidationExpression="[a-zA-Z' ']{1,30}$" ValidationGroup="signup"></asp:RegularExpressionValidator>--%>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="edad" TextMode="Number" CssClass="form-control" ValidationGroup="signup" min="16" max="110"></asp:TextBox>
                <label for="edad">Edad</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="edadvacio" runat="server" ControlToValidate="edad" ErrorMessage="Edad es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="edad" ErrorMessage="Edad debe ser un número entero" ValidationExpression="[0-9]{1,3}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="telefono" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="telefono">Teléfono</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="telefonovacio" runat="server" ControlToValidate="telefono" ErrorMessage="Teléfono es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="telefono" ErrorMessage="Teléfono no cumple con los requisitos" ValidationExpression="[0-9]{1,12}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="calle" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="calle">Calle</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="callevacio" runat="server" ControlToValidate="calle" ErrorMessage="Calle es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="calle" ErrorMessage="Calle no cumple con los requisitos" ValidationExpression="[a-zA-Z0-9' ']{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="pueblo" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="pueblo">Pueblo</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="pueblovacio" runat="server" ControlToValidate="pueblo" ErrorMessage="Pueblo es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="pueblo" ErrorMessage="Pueblo no cumple con los requisitos" ValidationExpression="[a-zA-Z' ']{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="provincia" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="provincia">Provincia</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="provinciavacio" runat="server" ControlToValidate="provincia" ErrorMessage="Provincia es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="provincia" ErrorMessage="Provincia no cumple con los requisitos" ValidationExpression="[a-zA-Z' ']{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="codpostal" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="codpostal">Código postal</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="codpostalvacio" runat="server" ControlToValidate="codpostal" ErrorMessage="Código postal es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="codpostal" ErrorMessage="Código postal no cumple con los requisitos" ValidationExpression="[0-9]{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="email" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="email">Email</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="emailvacio" runat="server" ControlToValidate="email" ErrorMessage="Email es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="email" ErrorMessage="Email no cumple con los requisitos" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="username2" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="username2">Username</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="username2vacio" runat="server" ControlToValidate="username2" ErrorMessage="Username es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="username2" ErrorMessage="Username debe contener caracteres alfanuméricos y no superar los 30 caracteres" ValidationExpression="[a-zA-Z0-9]{1,30}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox runat="server" ID="password2" TextMode="Password" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                <label for="password2">Contraseña</label>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="password2vacio" runat="server" ControlToValidate="password2" ErrorMessage="Contraseña es un campo obligatorio" SetFocusOnError="true" Display="Dynamic" ValidationGroup="signup"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="password2" ErrorMessage="Contraseña debe contener caracteres alfanuméricos y no superar los 30 caracteres" ValidationExpression="[a-zA-Z0-9]{1,30}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                </div>
            </div>
            <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.</p>
            <asp:Button class="regbutton" ID="registbutton" runat="server" Text="Registrarse" OnClick="Button2_Click" ValidationGroup="signup"/>
            <div class="container-fluid align-content-center" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
                <div class="alert alert-danger" role="alert" id="Div1" runat="server" >
                    <p class="message">
                        <asp:Label ID="Msg2" runat="server" ></asp:Label>
                        <asp:ValidationSummary ID="signupvalidations" runat="server" DisplayMode="BulletList" font-size="Small" ValidationGroup="signup"/>
                    </p>
                </div>
            </div>
        </asp:Panel>
    </div>
    <style>

        .container {
            border:3px solid black;
            background-color:white;
        }

        a {
            color: dodgerblue;
        }
        .regbutton{
            background-color: forestgreen;
            color: white;
            padding: 16px 20px;
            border: none;
            cursor: pointer;
            width: 100%;
            opacity: 0.9;
        }
    </style>

</asp:Content>



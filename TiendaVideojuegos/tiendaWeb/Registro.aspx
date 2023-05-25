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

             Nombre:<br /> <asp:TextBox ID="textNombre" runat="server" placeholder="Nombre"></asp:TextBox><br />
                 
             Apellidos:<br /> <asp:TextBox ID="textApellidos" runat="server" placeholder="Apellidos"></asp:TextBox><br />

              Edad:<br /> <asp:TextBox ID="textEdad" runat="server" placeholder="Edad"></asp:TextBox><br>

                  Número de teléfono:<br /> <asp:TextBox ID="textNumero" runat="server" placeholder="Número de teléfono"></asp:TextBox><br>

                  Dirección:<br /> <asp:TextBox ID="textDireccion" runat="server" placeholder="Dirección"></asp:TextBox><br />

                  Código Postal:<br /> <asp:TextBox ID="textCodigo" runat="server" placeholder="Código Postal"></asp:TextBox><br />

                  Localidad:<br /> <asp:TextBox ID="textLocalidad" runat="server" placeholder="Localidad"></asp:TextBox><br />
                  Provincia:<br /> <asp:TextBox ID="textProvincia" runat="server" placeholder="Provincia"></asp:TextBox><br />

         Nombre de usuario:<br /> <asp:TextBox ID="textUsername" runat="server" placeholder="Nombre de usuario"></asp:TextBox><br />
         Email:<br /> <asp:TextBox ID="textEmail" runat="server" placeholder="Email"></asp:TextBox>
         <asp:RegularExpressionValidator id="EmailValidator" 
                     ControlToValidate="textEmail"
                     ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"
                     Display="Static"
                     ErrorMessage="No es un correo válido"
                     runat="server"></asp:RegularExpressionValidator><br />
         Contraseña:<br /> <asp:TextBox ID="textPassword" runat="server" placeholder =" Contraseña" > </asp:TextBox><br />
         Repite contraseña:<br /> <asp:TextBox ID="textDoble" runat="server" placeholder =" Repite contraseña"> </asp:TextBox>
         <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.</p>
         <asp:Label ID="outputMsg2" runat="server" Text="Label"><br /></asp:Label>
         <asp:Button class="regbutton" ID="registbutton" runat="server" Text="Registrarse" OnClick="Button2_Click" />


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



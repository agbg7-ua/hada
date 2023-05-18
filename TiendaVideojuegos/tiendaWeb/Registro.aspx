<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="tiendaWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Inicio sesión/Registro </p>
    </div>

     <div class="container" style="width: 50%; float:left; height:400px;">
        <h3 style="text-align:center; margin-top:20px">Inicia sesión</h3><br />
         Usuario:<br /> <asp:TextBox ID="TextBox1" runat="server" placeholder="Usuario" ></asp:TextBox><br />
         Contraseña:<br /> <asp:TextBox ID="passwordTextBox" runat="server" placeholder =" Contraseña" TextMode="Password" ClientIDMode="Static"> </asp:TextBox><br />
        <asp:CheckBox ID="showPasswordCheckBox" runat="server" Text="Show Password" AutoPostBack="True" OnTextChanged="showPasswordButton_Click" /><br />
         <asp:Label ID="outputMsg" runat="server" Text="Label"><br /></asp:Label><br />
         <asp:Button class="regbutton" ID="iniciabutton" runat="server" Text="Iniciar sesión" OnClick="Button1_Click" />
     </div>
     <div class="container" style="width: 50%; float:right; height:900px">
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
       body {
           background-size:100%;
           background-color:white;
}
    .container {
        border:3px solid black;
        background-color:lightgrey;
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



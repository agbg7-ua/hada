<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="tiendaWeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col">
     <div class="container" style="width: 50%; float:left; height:1000px;">
                 <hr>
        <h3 style="text-align:center">Inicia sesión</h3><br />
         Usuario:<br /> <asp:TextBox ID="TextBox1" runat="server" placeholder="Usuario"></asp:TextBox>
         <asp:RequiredFieldValidator ID="UserNameReq" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Introduce el usuario!!">
         </asp:RequiredFieldValidator><br />
         Contraseña:<br /> <asp:TextBox ID="TextBox2" runat="server" placeholder =" Contraseña" TextMode="Password" ClientIDMode="Static"> </asp:TextBox>
         <asp:RequiredFieldValidator ID="PasswordReq" runat="server" ControlToValidate="TextBox2" ErrorMessage="Introduce la contraseña!!"></asp:RequiredFieldValidator><br />
         <asp:CheckBox ID="ckShowPass" runat="server" Text="Show password" onclick="myshowp()" />
         <asp:Button class="regbutton" ID="Button1" runat="server" Text="Iniciar sesión" />
         <hr />
     </div>
     <div class="container" style="width: 50%; float:right; height:1000px;">
         <hr>
        <h3 style="text-align: center;">Regístrate</h3><br />
         
         Email:<br /> <asp:TextBox ID="TextBox3" runat="server" placeholder="Email"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Requiredemail" runat="server"
            ControlToValidate="TextBox3" ErrorMessage="Introduce un correo electrónico!!"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator id="EmailValidator" 
                     ControlToValidate="TextBox3"
                     ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"
                     Display="Static"
                     ErrorMessage="No es un correo válido"
                     runat="server"></asp:RegularExpressionValidator><br />
         Contraseña:<br /> <asp:TextBox ID="TextBox4" runat="server" placeholder =" Contraseña" > </asp:TextBox>
         <asp:RequiredFieldValidator ID="Requiredpass" runat="server" ControlToValidate="TextBox4" ErrorMessage="Introduce una contraseña!!"></asp:RequiredFieldValidator><br />
         Repite contraseña:<br /> <asp:TextBox ID="TextBox5" runat="server" placeholder =" Repite contraseña"> </asp:TextBox>
         <asp:CompareValidator ID="Validator" runat ="server" ControlToValidate="TextBox5" ControlToCompare="TextBox4" Type="String" ErrorMessage="Introduce la misma contraseña!!" ></asp:CompareValidator>
         <asp:RequiredFieldValidator ID="RequiredReppass" runat="server" ControlToValidate="TextBox5"></asp:RequiredFieldValidator><br />
         <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.</p>
         <asp:Button class="regbutton" ID="Button2" runat="server" Text="Registrarse" />

         <hr />

     </div>
    </div>
    <script>
    function myshowp() {
        ckbox = $('#ckShowPass')
        txtBox = $('#TextBox2')

        if (ckbox.is(':checked')) {
            txtBox.attr("Type", "Text");
        }
        else {
            txtBox.attr("Type", "Password");
        }
    }
    </script>
   <style>
       body {
    background-image:url('https://marketplace.canva.com/EAE-Nstn9JQ/1/0/1600w/canva-purple-good-game-sunset-scene-gaming-desktop-wallpaper-xut5qXtG90k.jpg');
    background-repeat:no-repeat;
    background-attachment:fixed;
}
    .col{
    display: flex; 
    width: 100%;
    }
    .container {
        flex:1;
        padding: 16px;
    }
    hr {
    border: 1px solid black;
    margin-bottom:25px;
}
    a {
  color: dodgerblue;
    }
    .regbutton{
      background-color: purple;
      color: white;
      padding: 16px 20px;
      border: none;
      cursor: pointer;
      width: 100%;
      opacity: 0.9;
    }
</style>

</asp:Content>



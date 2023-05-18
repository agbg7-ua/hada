<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="tiendaWeb.Registro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col">
     <div class="container" style="width: 50%; float:left; height:800px;">
       <hr>
        <h3 style="text-align:center">Inicia sesión</h3><br />
         Usuario:<br /> <asp:TextBox ID="TextBox1" runat="server" placeholder="Usuario" ></asp:TextBox>
         <asp:RequiredFieldValidator ID="UserNameReq" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Introduce el usuario!!">
         </asp:RequiredFieldValidator><br />
         Contraseña:<br /> <asp:TextBox ID="passwordTextBox" runat="server" placeholder =" Contraseña" TextMode="Password" ClientIDMode="Static"> </asp:TextBox>
         <asp:RequiredFieldValidator ID="PasswordReq" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Introduce la contraseña!!"></asp:RequiredFieldValidator><br />
        <asp:CheckBox ID="showPasswordCheckBox" runat="server" Text="Show Password" AutoPostBack="True" OnTextChanged="showPasswordButton_Click" /><br />
         <asp:Label ID="outputMsg" runat="server" Text="Label"><br /></asp:Label>
         <asp:Button class="regbutton" ID="iniciabutton" runat="server" Text="Iniciar sesión" OnClick="Button1_Click" />
         <hr />
     </div>
     <div class="container" style="width: 50%; float:right; height:800px">
         <hr>
        <h3 style="text-align: center;">Regístrate</h3><br />

             Nombre:<br /> <asp:TextBox ID="textNombre" runat="server" placeholder="Nombre"></asp:TextBox><br />
                 
             Apellidos:<br /> <asp:TextBox ID="textApellidos" runat="server" placeholder="Apellidos"></asp:TextBox><br />


                  Número de teléfono:<br /> <asp:TextBox ID="textNumero" runat="server" placeholder="Número de teléfono"></asp:TextBox><br>

                  Dirección:<br /> <asp:TextBox ID="textDireccion" runat="server" placeholder="Dirección"></asp:TextBox><br />

                  Código Postal:<br /> <asp:TextBox ID="textCodigo" runat="server" placeholder="Código Postal"></asp:TextBox><br />

                  Localidad:<br /> <asp:DropDownList ID="DropDownList1" runat="server"
                            Width="90px" AutoPostBack="False">
                             <asp:ListItem Value="Be">Benidorm</asp:ListItem>
                             <asp:ListItem>Torrevieja</asp:ListItem>
                             <asp:ListItem>Sagunto</asp:ListItem>
                            </asp:DropDownList><br />

                  Provincia:<br /> <asp:DropDownList ID="DropDownList3" runat="server"
                            Width="90px" AutoPostBack="False">
                             <asp:ListItem Value="Al">Alicante</asp:ListItem>
                             <asp:ListItem>Castellón</asp:ListItem>
                             <asp:ListItem>Valencia</asp:ListItem>
                            </asp:DropDownList><br />

         Nombre de usuario:<br /> <asp:TextBox ID="textUsername" runat="server" placeholder="Nombre de usuario"></asp:TextBox><br />
         Email:<br /> <asp:TextBox ID="textEmail" runat="server" placeholder="Email"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Requiredemail" runat="server"
            ControlToValidate="textEmail" ErrorMessage="Introduce un correo electrónico!!"></asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator id="EmailValidator" 
                     ControlToValidate="textEmail"
                     ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"
                     Display="Static"
                     ErrorMessage="No es un correo válido"
                     runat="server"></asp:RegularExpressionValidator><br />
         Contraseña:<br /> <asp:TextBox ID="textPassword" runat="server" placeholder =" Contraseña" > </asp:TextBox>
         <asp:RequiredFieldValidator ID="Requiredpass" runat="server" ControlToValidate="textPassword" ErrorMessage="Introduce una contraseña!!"></asp:RequiredFieldValidator><br />
         Repite contraseña:<br /> <asp:TextBox ID="textDoble" runat="server" placeholder =" Repite contraseña"> </asp:TextBox>
         <asp:CompareValidator ID="Validator" runat ="server" ControlToValidate="textDoble" ControlToCompare="textPassword" Type="String" ErrorMessage="Introduce la misma contraseña!!" ></asp:CompareValidator>
         <p>By creating an account you agree to our <a href="#">Terms & Privacy</a>.</p>
         <asp:Label ID="outputMsg2" runat="server" Text="Label"><br /></asp:Label>
         <asp:Button class="regbutton" ID="registbutton" runat="server" Text="Registrarse" OnClick="Button2_Click" />

         <hr />

     </div>
    </div>
   <style>
       body {
           background-size:100%;
           background-color:white;
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
           width: 715px;
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



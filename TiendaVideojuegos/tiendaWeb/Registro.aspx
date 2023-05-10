<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="tiendaWeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="styles.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="col">
     <div class="container" style="width: 50%; float:left; height:800px;">
       <hr>
        <h3 style="text-align:center">Inicia sesión</h3><br />
         Usuario:<br /> <asp:TextBox ID="TextBox1" runat="server" placeholder="Usuario" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
         <asp:RequiredFieldValidator ID="UserNameReq" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Introduce el usuario!!">
         </asp:RequiredFieldValidator><br />
         Contraseña:<br /> <asp:TextBox ID="TextBox2" runat="server" placeholder =" Contraseña" TextMode="Password" ClientIDMode="Static" OnTextChanged="TextBox2_TextChanged"> </asp:TextBox>
         <asp:RequiredFieldValidator ID="PasswordReq" runat="server" ControlToValidate="TextBox2" ErrorMessage="Introduce la contraseña!!"></asp:RequiredFieldValidator><br />
         <asp:CheckBox ID="ckShowPass" runat="server" Text="Show password" onclick="myshowp()" OnCheckedChanged="ckShowPass_CheckedChanged" />
         <asp:Button class="regbutton" ID="Button1" runat="server" Text="Iniciar sesión" OnClick="Button1_Click" />
         <hr />
     </div>
     <div class="container" style="width: 50%; float:right; height:800px">
         <hr>
        <h3 style="text-align: center;">Regístrate</h3><br />
         <div>
             <div style="float:left">
             Nombre:<br /> <asp:TextBox ID="TextBox6" runat="server" placeholder="Nombre"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="TextBox6" ErrorMessage="Introduce un nombre!!"></asp:RequiredFieldValidator><br />
             </div>
             <div style="float:right">
                 
                     Apellidos:<br /> <asp:TextBox ID="TextBox7" runat="server" placeholder="Apellidos"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
            ControlToValidate="TextBox7" ErrorMessage="Introduce apellidos!"></asp:RequiredFieldValidator><br />
             </div>
         </div>

                  Número de teléfono:<br /> <asp:TextBox ID="TextBox8" runat="server" placeholder="Número de teléfono"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
            ControlToValidate="TextBox3" ErrorMessage="Introduce un número de teléfono!!"></asp:RequiredFieldValidator><br />
                  Dirección:<br /> <asp:TextBox ID="TextBox9" runat="server" placeholder="Dirección"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
            ControlToValidate="TextBox9" ErrorMessage="Introduce una dirección!!"></asp:RequiredFieldValidator><br />
                  Código Postal:<br /> <asp:TextBox ID="TextBox10" runat="server" placeholder="Código Postal"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
            ControlToValidate="TextBox10" ErrorMessage="Introduce un código postal!!"></asp:RequiredFieldValidator><br />
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
                  País:<br /> <asp:DropDownList ID="DropDownList2" runat="server"
                            Width="90px" AutoPostBack="False">
                             <asp:ListItem Value="Esp">España</asp:ListItem>
                             <asp:ListItem>Portugal</asp:ListItem>
                             <asp:ListItem>Italia</asp:ListItem>
                            </asp:DropDownList><br />
         
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



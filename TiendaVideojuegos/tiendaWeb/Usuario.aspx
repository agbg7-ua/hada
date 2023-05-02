<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="tiendaWeb.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="father">
     <div class="container1" style="width: 50%; float:left; height:1000px;border: 1px solid grey;text-align: center;">
        <h3>Inicia sesión</h3><br />
         Usuario: <asp:TextBox ID="TextBox1" runat="server" placeholder="Usuario"></asp:TextBox>
         <asp:RequiredFieldValidator ID="UserNameReq" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Introduce el usuario!!">
         </asp:RequiredFieldValidator><br />
         Contraseña: <asp:TextBox ID="TextBox2" runat="server" placeholder =" Contraseña"> </asp:TextBox>
         <asp:RequiredFieldValidator ID="PasswordReq" runat="server" ControlToValidate="TextBox2" ErrorMessage="Introduce el password!!"></asp:RequiredFieldValidator><br />
         <asp:Button ID="Button1" runat="server" Text="Enviar" />
     </div>
     <div class="container2" style="width: 50%; float:right; height:1000px;border: 1px solid grey;text-align: center;">
        <h3>Registrate</h3><br />
         <hr>
         Usuario: <asp:TextBox ID="TextBox3" runat="server" placeholder="Usuario"></asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="TextBox1" ErrorMessage="Introduce el usuario!!">
         </asp:RequiredFieldValidator><br />
         Contraseña: <asp:TextBox ID="TextBox4" runat="server" placeholder =" Contraseña"> </asp:TextBox>
         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Introduce el password!!"></asp:RequiredFieldValidator><br />
         <asp:Button ID="Button2" runat="server" Text="Enviar" />
         <hr />

     </div>
    </div>

</asp:Content>


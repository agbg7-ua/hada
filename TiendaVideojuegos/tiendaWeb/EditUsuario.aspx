<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditUsuario.aspx.cs" Inherits="tiendaWeb.EditUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>TU PERFIL</h1>
     <div class="col">
     <div class="container" style="width: 50%; float:left; height:750px;text-align:center;border-right:3px solid black;border-bottom:3px solid black;border-top:3px solid black">
            <img src="https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2018/08/fotos-perfil-whatsapp_16.jpg?tf=3840x" alt="Avatar" class="avatar" style="margin:3px">
            <p style="font-size:20px;margin:3px">  <asp:TextBox ID="TextBox10" runat="server" placeholder =" Nombre de usuario"></asp:TextBox></p><br />
            <p style="font-size:20px;margin:3px">  <asp:TextBox ID="TextBox9" runat="server" placeholder =" Correo electrónico"></asp:TextBox></p>
     </div>
     <div class="container" style="width: 50%; float:right; height:750px;border-bottom:3px solid black;text-align:center;border-top:3px solid black">
        <h3 style="text-align: center;">Información</h3><br />
            <p style="font-size:20px;margin:3px"> Nombre:<br /> <asp:TextBox ID="TextBox2" runat="server" placeholder ="Nombre"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> Apellidos:<br />  <asp:TextBox ID="TextBox1" runat="server" placeholder ="Apellidos"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> Número de teléfono:<br />  <asp:TextBox ID="TextBox3" runat="server" placeholder ="Número de teléfono"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> Dirección:<br />  <asp:TextBox ID="TextBox4" runat="server" placeholder ="Dirección"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> Código postal:<br />  <asp:TextBox ID="TextBox5" runat="server" placeholder ="Código postal"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> Localidad:<br />  <asp:TextBox ID="TextBox6" runat="server" placeholder ="Localidad"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> Provincia:<br />  <asp:TextBox ID="TextBox7" runat="server" placeholder ="Provincia"></asp:TextBox> </p>
            <p style="font-size:20px;margin:3px"> País:<br /> <asp:TextBox ID="TextBox8" runat="server" placeholder ="País"></asp:TextBox> </p><br />
            <asp:Button class="regbutton" ID="Button1" runat="server" Text="Editar usuario" />

     </div>
    </div>
     <style>
       body {
           background-size:100%;
              background-repeat:no-repeat;
    background-attachment:fixed;
           background-image:url(https://img.pikbest.com/backgrounds/20220119/gradient-background-purple_6244676.jpg!bw700);
    text-align:center;
}
           .avatar {
  width: 60%;
  height: 300px;
  border-radius: 50%;
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
      background-color: black;
      color: white;
      padding: 16px 20px;
      border: none;
      cursor: pointer;
      width: 90%;
      opacity: 0.9;
    }
</style>
</asp:Content>

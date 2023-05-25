<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditUsuario.aspx.cs" Inherits="tiendaWeb.EditUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Edita tu Perfil </p>
    </div>

     <div class="col">
     <div class="container" style="width: 50%; float:left; height:750px;text-align:center;border-right:3px solid black;border-bottom:3px solid black;border-top:3px solid black">
            <asp:Image ID="Image1" runat="server" ImageUrl="Imagenes/profile.jpg"  alt="Avatar" class="avatar" style="margin:3px"/><br>
            <b style="font-size:20px;margin:3px">Nombre de Usuario:<br /></b><p style="font-size:20px;margin:3px">  <asp:TextBox ID="TextBox10" runat="server" placeholder =" Nombre de usuario"></asp:TextBox></p><br />
            <b style="font-size:20px;margin:3px">Email:<br /></b><p style="font-size:20px;margin:3px">  <asp:TextBox ID="TextBox9" runat="server" placeholder =" Correo electrónico"></asp:TextBox></p>
     </div>
     <div class="container" style="width: 50%; float:right; height:750px;border-bottom:3px solid black;text-align:center;border-top:3px solid black">
        <h3 style="text-align: center;">Información</h3><br />
            <p style="font-size:20px;margin:3px"><b> Nombre:<br /> <asp:TextBox ID="TextBox2" runat="server" placeholder ="Nombre"></asp:TextBox></b></p>
            <p style="font-size:20px;margin:3px"> <b>Apellidos:<br /> </b> <asp:TextBox ID="TextBox1" runat="server" placeholder ="Apellidos"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> <b>Número de teléfono:<br /></b>  <asp:TextBox ID="TextBox3" runat="server" placeholder ="Número de teléfono"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> <b>Dirección:<br /> </b> <asp:TextBox ID="TextBox4" runat="server" placeholder ="Dirección"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> <b>Código postal:<br /> </b> <asp:TextBox ID="TextBox5" runat="server" placeholder ="Código postal"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> <b>Localidad:<br /> </b> <asp:TextBox ID="TextBox6" runat="server" placeholder ="Localidad"></asp:TextBox></p>
            <p style="font-size:20px;margin:3px"> <b>Provincia:<br /> </b> <asp:TextBox ID="TextBox7" runat="server" placeholder ="Provincia"></asp:TextBox> </p>
            <p style="font-size:20px;margin:3px"><b> Edad:<br /></b> <asp:TextBox ID="TextBox8" runat="server" placeholder ="País"></asp:TextBox> </p><br />
            <asp:Label ID="outputMsg" runat="server" Text="Label"><br /></asp:Label>
            <asp:Button class="regbutton" ID="Button1" runat="server" Text="Finalizar" OnClick="Button1_Click" />

     </div>
    </div>
     <style>
       body {
           background-size:100%;
            background-color:white;
    text-align:center;
}
           .avatar {
  width: 60%;
  height: 400px;
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
      background-color: grey;
      color: white;
      padding: 16px 20px;
      border: none;
      cursor: pointer;
      width: 90%;
      opacity: 0.9;
    }
</style>
</asp:Content>

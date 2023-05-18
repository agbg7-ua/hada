<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="tiendaWeb.Usuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Tu Perfil </p>
    </div>

     <div class="col">
     <div class="container" style="width: 50%; float:left; height:650px;text-align:center;border-right:3px solid black;border-bottom:3px solid black;border-top:3px solid black">
            <asp:Image ID="Image1" runat="server" ImageUrl="Imagenes/profile.jpg"  alt="Avatar" class="avatar" style="margin:3px"/><br>
            <b style="font-size:20px;margin:3px">Nombre de Usuario:<br /></b><asp:Label ID="Username" runat="server" style="font-size:20px;margin:3px"> Adriana2304</asp:Label><br />
            <b style="font-size:20px;margin:3px">Email:<br /></b><asp:Label ID="EmailUsu" runat="server" style="font-size:20px;margin:3px"> Adriana2304@gmail.com</asp:Label>
     </div>
     <div class="container" style="width: 50%; float:right; height:650px;border-bottom:3px solid black;text-align:center;border-top:3px solid black">
        <h3 style="text-align: center;">Información</h3><br />
            <b style="font-size:20px;margin:3px">Nombre:<br /></b><asp:Label ID="NameUsu" runat="server" style="font-size:20px;margin:3px"> Adriana</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Apellidos:<br /></b><asp:Label ID="SurnameUsu" runat="server" style="font-size:20px;margin:3px"> González Romero</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Edad:<br /></b><asp:Label ID="EdadUsu" runat="server" style="font-size:20px;margin:3px"> 23</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Número de teléfono:<br /></b><asp:Label ID="NumberUsu" runat="server" style="font-size:20px;margin:3px"> 649673124</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Dirección:<br /></b><asp:Label ID="AddresUsu" runat="server" style="font-size:20px;margin:3px"> Calle Poniente, 3, piso 4, puerta A</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Código postal:<br /></b> <asp:Label ID="PostUsu" runat="server" style="font-size:20px;margin:3px">03560</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Localidad:<br /></b><asp:Label ID="LocationUsu" runat="server" style="font-size:20px;margin:3px"> Benidorm</asp:Label><br />
            <b style="font-size:20px;margin:3px"> Provincia:<br /></b><asp:Label ID="ProvUsu" runat="server" style="font-size:20px;margin:3px"> Alicante </asp:Label><br />
            <asp:Button class="regbutton" ID="Button1" runat="server" style="margin:3px" Text="Editar usuario" PostBackUrl= "~/EditUsuario.aspx" />

     </div>
    </div>
     <style>
       body {
        background-size:100%;
        text-align:center;
        background-color:white;
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

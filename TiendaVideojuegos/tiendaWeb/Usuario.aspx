<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="tiendaWeb.Usuario1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>TU PERFIL</h1>
     <div class="col">
     <div class="container" style="width: 50%; float:left; height:650px;text-align:center;border-right:3px solid black;border-bottom:3px solid black;border-top:3px solid black">
            <img src="https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2018/08/fotos-perfil-whatsapp_16.jpg?tf=3840x" alt="Avatar" class="avatar" style="margin:3px">
            <p style="font-size:20px;margin:3px"> Adriana2304</p>
            <p style="font-size:20px;margin:3px"> Adriana2304@gmail.com</p>
     </div>
     <div class="container" style="width: 50%; float:right; height:650px;border-bottom:3px solid black;text-align:center;border-top:3px solid black">
        <h3 style="text-align: center;">Información</h3><br />
            <p style="font-size:20px;margin:3px"> Nombre:<br /> Adriana</p>
            <p style="font-size:20px;margin:3px"> Apellidos:<br /> González Romero</p>
            <p style="font-size:20px;margin:3px"> Número de teléfono:<br /> 649673124</p>
            <p style="font-size:20px;margin:3px"> Dirección:<br /> Calle Poniente, 3, piso 4, puerta A</p>
            <p style="font-size:20px;margin:3px"> Código postal:<br /> 03560</p>
            <p style="font-size:20px;margin:3px"> Localidad:<br /> Benidorm</p>
            <p style="font-size:20px;margin:3px"> Provincia:<br /> Alicante </p>
            <p style="font-size:20px;margin:3px"> País:<br /> España </p>
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
      background-color: mediumpurple;
      color: white;
      padding: 16px 20px;
      border: none;
      cursor: pointer;
      width: 90%;
      opacity: 0.9;
    }
</style>
</asp:Content>

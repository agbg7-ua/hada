<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevoComentario.aspx.cs" Inherits="tiendaWeb.NuevoComentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="he">
        <h2 style="margin:15px">Escribir una opinión</h2>
    </div>

    <div class ="container">
        <h5> Valoración</h5>
        <div style="margin:10px">
            <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        </div>

    </div>
    <div class =" container">
        <h5>Añade un titulo</h5>
        <asp:TextBox ID="TextBox4" runat="server" placeholder =" Añada lo que es importante" TextMode="multiline" style="width:80%;margin:10px; background-color:lightgrey;"> </asp:TextBox>
    </div>
    <div class="container">

        <form action="upload.php" method="post" style="background-color:lightgray">
                    <h5>Añade imagenes</h5>
            <input type="file" name="file" id="file" style="margin:10px;"/>
        </form>
    </div>
    <div class="container">
        <h5>Añade una valoración escrita</h5>
        <asp:TextBox ID="TextBox1" runat="server" placeholder =" Añada su valoración detallada del producto" TextMode="multiline" style="width:80%; margin: 10px; background-color:lightgray"> </asp:TextBox>
    </div>
    <div class="button">
        <asp:Button class="regbutton" ID="Button1" runat="server" Text="Enviar" />
    </div>

    <style>
        body{
            align-content:center;
            background-image:url('https://media.istockphoto.com/id/1300397135/es/vector/violeta-p%C3%BArpura-y-azul-marino-desenfocado-borroso-degradado-fondo-abstracto.jpg?s=612x612&w=0&k=20&c=P0fh4umq5ZIa4ujpo67zGzg-oMcdqQxtDx97fZxP3As=');
            background-repeat:no-repeat;
            background-attachment:fixed;
            background-size:100%;

        }
        .he{
            text-align:center;
        }
        .fa {
  font-size: 25px;
}
        .container{
            border-bottom: 1px solid grey;
            border-top: 1px solid grey;
        }
    </style>
</asp:Content>


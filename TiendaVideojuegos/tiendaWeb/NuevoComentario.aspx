<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevoComentario.aspx.cs" Inherits="tiendaWeb.NuevoComentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Nuevo Comentario </p>
    </div>
    <div class ="container">
        <h5 style="margin-top:10px"> Valoración</h5>
        <div style="margin:10px">
            <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        <span class="fa fa-star"></span>
        </div>

    </div>
    <div class =" container">
        <h5 style="margin-top:10px">Añade un titulo</h5>
        <asp:TextBox ID="TextBox4" runat="server" placeholder =" Añada lo que es importante" TextMode="multiline" style="width:80%;margin:10px; background-color:lightgrey;"> </asp:TextBox>
    </div>
    <div class="container">

        <form action="upload.php" method="post" style="background-color:lightgray">
                    <h5 style =" margin-top:10px">Añade imagenes</h5>
            <input type="file" name="file" id="file" style="margin:10px;"/>
        </form>
    </div>
    <div class="container">
        <h5 style="margin-top:10px">Añade una valoración escrita</h5>
        <asp:TextBox ID="TextBox1" runat="server" placeholder =" Añada su valoración detallada del producto" TextMode="multiline" style="width:80%; margin: 10px; background-color:lightgray"> </asp:TextBox>
    </div>
    <div class="button" style = "margin-top= 10px;width:20%;float:right">
        <asp:Button class="regbutton" ID="Button1" runat="server" Text="Enviar" />
    </div>

    <style>
        body{
            align-content:center;
           

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


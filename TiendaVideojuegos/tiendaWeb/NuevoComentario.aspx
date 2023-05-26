﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevoComentario.aspx.cs" Inherits="tiendaWeb.NuevoComentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Nuevo Comentario </p>
    </div>

    <div style="min-height: 100vh">
        <div class ="container">
            <h5 style="margin-top:10px"> Valoración</h5>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" style=" margin: 10px; background-color:lightgray" min="1" max="5" onkeydown="return false" Text="1"> </asp:TextBox>

        </div>
        <div class="container">
            <h5 style="margin-top:10px">Añade una valoración escrita</h5>
            <asp:TextBox ID="TextBox1" runat="server" placeholder =" Añada su valoración detallada del producto" TextMode="multiline" style="width:80%; margin: 10px; background-color:lightgray"> </asp:TextBox>
            <asp:Label ID="outputMsg" runat="server" Text="Label"><br /></asp:Label><br />
        </div>
        <div class="button" style = "margin-top: 10px;width:20%;float:right">
            <asp:Button class="regbutton" ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
        </div>
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
        border-bottom: 2px solid black;
    }
    </style>
</asp:Content>


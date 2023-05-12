<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.ProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Videojuegos </p>
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <div class="text-center" style="padding-right: 5px;">
            <asp:Button runat="server" Height="50px" ID="usuario" CssClass="btn btn-secondary" Text="Usuarios" OnClientClick="button_usuarioOnClientClick" OnClick="button_usuarioOnClientClick"/>
            <asp:Button runat="server" Height="50px" ID="producto" CssClass="btn btn-secondary" Text="Videojuegos" OnClientClick="button_productoOnClientClick" OnClick="button_productoOnClientClick"/>
            <asp:Button runat="server" Height="50px" ID="categoria" CssClass="btn btn-secondary" Text="Géneros" OnClientClick="button_categoriaOnClientClick" OnClick="button_categoriaOnClientClick"/>
            <asp:Button runat="server" Height="50px" ID="carrito" CssClass="btn btn-secondary" Text="Carritos" OnClientClick="button_carritoOnClientClick" OnClick="button_carritoOnClientClick"/>
            <asp:Button runat="server" Height="50px" ID="pedido" CssClass="btn btn-secondary" Text="Pedidos" OnClientClick="button_pedidoOnClientClick" OnClick="button_pedidoOnClientClick"/>
            <asp:Button runat="server" Height="50px" ID="desarrollador" CssClass="btn btn-secondary" Text="Desarrolladores" OnClientClick="button_desarrolladorOnClientClick" OnClick="button_desarrolladorOnClientClick"/>
        </div>
    </div>

</asp:Content>

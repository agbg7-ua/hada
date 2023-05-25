<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="tiendaWeb.Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark">Administrador </p>
    </div>
    <br />

    <div class="container-fluid" style="height: 100%">
        <div style="width: 100%; height: 100px; align-content: center; text-align: center">
            <blockquote class="blockquote">
                <p style="font-family: 'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif"><strong>Bienvenido a Administración</strong></p>
            </blockquote>
        </div>

        <div style="width: 100%; height: 100px; align-content: center; text-align: center">
            <div class="text-center" style="padding-right: 5px;">
                <asp:Button runat="server" Height="50px" ID="usuario" CssClass="btn btn-secondary" Text="Usuarios" OnClientClick="button_usuarioOnClientClick" OnClick="button_usuarioOnClientClick" />
                <asp:Button runat="server" Height="50px" ID="producto" CssClass="btn btn-secondary" Text="Videojuegos" OnClientClick="button_productoOnClientClick" OnClick="button_productoOnClientClick" />
                <asp:Button runat="server" Height="50px" ID="categoria" CssClass="btn btn-secondary" Text="Géneros" OnClientClick="button_categoriaOnClientClick" OnClick="button_categoriaOnClientClick" />
                <asp:Button runat="server" Height="50px" ID="carrito" CssClass="btn btn-secondary" Text="Carritos" OnClientClick="button_carritoOnClientClick" OnClick="button_carritoOnClientClick" />
                <asp:Button runat="server" Height="50px" ID="pedido" CssClass="btn btn-secondary" Text="Pedidos" OnClientClick="button_pedidoOnClientClick" OnClick="button_pedidoOnClientClick" />
                <asp:Button runat="server" Height="50px" ID="desarrollador" CssClass="btn btn-secondary" Text="Desarrolladores" OnClientClick="button_desarrolladorOnClientClick" OnClick="button_desarrolladorOnClientClick" />
                <asp:Button runat="server" Height="50px" ID="oferta" CssClass="btn btn-secondary" Text="Ofertas" OnClick="oferta_Click" />

            </div>
        </div>
    </div>

</asp:Content>

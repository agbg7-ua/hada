<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LineaPedido.aspx.cs" Inherits="tiendaWeb.LineaPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Línea de pedido</h2>
    <p>ID Pedido: <asp:TextBox ID="IDPedBox" runat="server"></asp:TextBox></p>
    <p>ID Linea: <asp:TextBox ID="IDLBox" runat="server"></asp:TextBox></p>
    <p>ID Producto: <asp:TextBox ID="IDProdBox" runat="server"></asp:TextBox></p>
    <p>Cantidad: <asp:TextBox ID="CantBox" runat="server"></asp:TextBox></p>
    <p>Importe: <asp:TextBox ID="ImportBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Button ID="ButtonCreate" runat="server" Text="Crear" />
        <asp:Button ID="ButtonUpdate" runat="server" Text="Actualizar" />
        <asp:Button ID="ButtonDelete" runat="server" Text="Borrar" />
    </p>
    <p>
        <asp:Button ID="ButtonAll" runat="server" Text="Mostrar todas las líneas de pedido" />
        <asp:Button ID="ButtonAllPed" runat="server" Text="Mostrar todas las líneas de un mismo pedido" />
        <asp:Button ID="ButtonAllProd" runat="server" Text="Mostrar todas las líneas de un mismo producto" />
    </p>
    <p>
        <asp:GridView ID="DataTable" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </p>
</asp:Content>

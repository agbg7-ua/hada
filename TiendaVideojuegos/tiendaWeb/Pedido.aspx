<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="tiendaWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Pedido</h2>
    <p>ID: <asp:TextBox ID="IDBox" runat="server"></asp:TextBox></p>
    <p>Usuario: <asp:TextBox ID="UserBox" runat="server"></asp:TextBox></p>
    <p>Fecha: <asp:TextBox ID="DateBox" runat="server"></asp:TextBox></p>
    <p>Importe Total: <asp:TextBox ID="ITotalBox" runat="server"></asp:TextBox></p>
    <p><asp:Button ID="ButtonID" runat="server" Text="Buscar por ID" OnClick="ButtonID_Click" />
        <asp:Button ID="ButtonCreate" runat="server" Text="Crear" />
        <asp:Button ID="ButtonUpdate" runat="server" Text="Actualizar" />
        <asp:Button ID="ButtonDelete" runat="server" Text="Borrar" />
    </p>
    <p><asp:Button ID="ButtonUser" runat="server" Text="Mostrar pedidos usuario" />
        <asp:Button ID="ButtonAll" runat="server" Text="Mostrar todos los pedidos" />
        <asp:Button ID="ButtonAsc" runat="server" Text="Mostrar todos los pedidos por importe (Ascendente)" />
        <asp:Button ID="ButtonDesc" runat="server" Text="Mostrar todos los pedidos por importe (Descendente)" />
    </p>
    <p>
        <asp:GridView ID="DataTable" runat="server" AutoGenerateColumns="true"></asp:GridView>
    </p>
</asp:Content>

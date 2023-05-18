<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="tiendaWeb.Admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administrador </p>
        <div class="dropdown">
            <asp:dropdownlist runat="server" id="ddlTest" CssClass="float-right btn btn-secondary dropdown-toggle" OnSelectedIndexChanged="ddlTest_SelectedIndexChanged" AutoPostBack="true"> 
                 <asp:listitem text="..." value="0" Selected="True"></asp:listitem>
                 <asp:listitem text="Géneros" value="1"></asp:listitem>
                 <asp:listitem text="Videojuegos" value="2"></asp:listitem>
                 <asp:listitem text="Desarrolladoras" value="3"></asp:listitem>
                 <asp:listitem text="Pedidos" value="4"></asp:listitem>
            </asp:dropdownlist>
        </div>
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

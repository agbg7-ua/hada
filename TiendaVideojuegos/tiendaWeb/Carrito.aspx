<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="tiendaWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> 
        <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-cart4" viewBox="0 0 30 30">
            <path d="M0 2.5A.5.5 0 0 1 .5 2H2a.5.5 0 0 1 .485.379L2.89 4H14.5a.5.5 0 0 1 .485.621l-1.5 6A.5.5 0 0 1 13 11H4a.5.5 0 0 1-.485-.379L1.61 3H.5a.5.5 0 0 1-.5-.5zM3.14 5l.5 2H5V5H3.14zM6 5v2h2V5H6zm3 0v2h2V5H9zm3 0v2h1.36l.5-2H12zm1.11 3H12v2h.61l.5-2zM11 8H9v2h2V8zM8 8H6v2h2V8zM5 8H3.89l.5 2H5V8zm0 5a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0zm9-1a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0z"/>
        </svg>
        Carrito </p>
    </div>

    <asp:ListView runat="server" ID="listView" OnItemDataBound="ImagenProducto">
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </tr>
        </GroupTemplate>

        <LayoutTemplate>
            <table class="table table-hover border-bottom border-dark" style="padding-left: 20px;">
                <thead class="thead-dark">
                    <tr>
                        <th>
                            Linea de Carrito
                        </th>
                        <th>
                            Imagen de Producto
                        </th>
                        <th>
                            Nombre de Producto
                        </th>
                        <th>
                            Cantidad
                        </th>
                        <th>
                            Importe
                        </th>
                        <th>
                            Opciones
                        </th>
                    </tr>
                </thead>
                <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
            </table>
        </LayoutTemplate>

        <ItemTemplate>
            <td>
                 <%# Eval("id_linea") %>
            </td>
            <td>
                 <asp:Image ID="Image1" runat="server" Width="60px" Height="60px" ImageUrl="" />	
            </td>
            <td>
                <asp:Label ID="nombre" runat="server" CssClass="label label-default" />
            </td>
            <td>
                <%# Eval("cantidad") %>
            </td>
            <td>
                <%# Eval("importe") %>
            </td>
            <td>
                <asp:LinkButton runat="server" id="borrar" CssClass="btn btn-danger" OnClientClick="ButtonBorrar" OnClick="ButtonBorrar" Text="Borrar" CommandArgument='<%#Eval("id_linea") + ";" + Eval("id_carrito")%>' />
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />

    <div class="" style="padding-left: 20px;">
        <asp:Label runat="server" ID="total" CssClass="font-weight-bold"></asp:Label>
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

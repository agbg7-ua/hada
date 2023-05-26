<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.ProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Videojuegos </p>
        <!-- Botón de añadir -->
        <asp:LinkButton runat="server" id="añadir" CssClass="btn btn-outline-success" OnClientClick="ButtonAñadir" OnClick="ButtonAñadir" Text="Añadir" />
    </div>

    <!-- ListView para listar los Productos -->
    <asp:ListView runat="server" ID="listView" OnItemDataBound="ImagenClasificacion">
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </tr>
        </GroupTemplate>

        <LayoutTemplate>
            <!-- table para mostrar los productos -->
            <!-- Columnas: id, imagen, nombre, precio, fecha de salida, clasificación, mostrar y opciones -->
            <table class="table table-hover border-bottom border-dark" style="padding-left: 20px;">
                <thead class="thead-dark">
                    <tr>
                        <th>
                            Id
                        </th>
                        <th>
                            Imagen
                        </th>
                        <th>
                            Nombre
                        </th>
                        <th>
                            Precio
                        </th>
                        <th>
                            Fecha de salida
                        </th>
                        <th>
                            Clasificación
                        </th>
                        <th>
                            Mostrar
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
                 <%# Eval("id") %>
            </td>
            <td>
                 <asp:Image ID="Image1" runat="server" Width="60px" Height="60px" ImageUrl='<%# Eval("imagen") %>' />	
            </td>
            <td>
                <%# Eval("nombre") %>
            </td>
            <td>
                <%# Eval("pvp") %>€
            </td>
            <td>
                <%# Eval("fecha_salida") %>
            </td>
            <td>
                <asp:Image ID="Imagen1" runat="server" Width="40px" Height="40px" ImageUrl='<%# Eval("imagen") %>' />
            </td>
            <td>
                <%# Eval("mostrar") %>
            </td>
            <!-- Botones de editar y borrar pasando el id del producto -->
            <td>
                <asp:LinkButton runat="server" id="editar" CssClass="btn btn-warning" OnClientClick="ButtonEditar" OnClick="ButtonEditar" Text="Editar" CommandArgument='<%#Eval("id") %>' />
                <asp:LinkButton runat="server" id="borrar" CssClass="btn btn-danger" OnClientClick="ButtonBorrar" OnClick="ButtonBorrar" Text="Borrar" CommandArgument='<%#Eval("id") %>' />
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />

    <!-- Label que aparecerá cuando no haya categorías -->
    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

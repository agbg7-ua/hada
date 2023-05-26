<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CategoriaProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.CategoriaProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Géneros de Videojuegos </p>
        <!-- Botón de añadir -->
        <asp:LinkButton runat="server" id="añadir" CssClass="btn btn-outline-success" OnClientClick="ButtonAñadir" OnClick="ButtonAñadir" Text="Añadir" />
    </div>

    <div style="min-height: 100vh">
        <!-- ListView para listar las Categorías de los Productos -->
        <asp:ListView runat="server" ID="listView">
            <GroupTemplate>
                <tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </tr>
            </GroupTemplate>

            <LayoutTemplate>
            <!-- table para mostrar las categorías -->
            <!-- Columnas: id, imagen, nombre, descripción y opciones -->
                <table class="table table-hover border-bottom border-dark">
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
                                Descripción
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
                <td style="width: 40%; padding-right: 20px;">
                    <%# Eval("descripcion") %>
                </td>
                <!-- Botones de editar y borrar pasando el id de la categoría -->
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
    </div>
</asp:Content>

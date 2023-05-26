<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UsuarioAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.UsuarioAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
     <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Usuarios </p>
    </div>

    <!-- ListView para listar las Categorías de los Productos -->
    <asp:ListView runat="server" ID="listView">
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </tr>
        </GroupTemplate>

        <LayoutTemplate>
            <!-- table para mostrar los usuarios -->
            <!-- Columnas: username, nombre, apellidos, email, telefono, admin y opciones -->
            <table class="table table-hover border-bottom border-dark" style="padding-left: 20px;">
                <thead class="thead-dark">
                    <tr>
                        <th>
                            Username
                        </th>
                        <th>
                            Nombre
                        </th>
                        <th>
                            Apellidos
                        </th>
                        <th>
                            Email
                        </th>
                        <th>
                            Teléfono
                        </th>
                        <th>
                            Admin
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
                 <%# Eval("username") %>
            </td>
            <td>
                <%# Eval("nombre") %>
            </td>
            <td>
                <%# Eval("apellidos") %>
            </td>
            <td>
                <%# Eval("email") %>
            </td>
            <td>
                <%# Eval("telefono") %>
            </td>
            <td>
                <%# Eval("admin") %>
            </td>
            <!-- Botones de cambiar administrador y borrar pasando el username del usuario -->
            <td>
                <asp:LinkButton runat="server" id="cambiar" CssClass="btn btn-success" OnClientClick="ButtonCambiar" OnClick="ButtonCambiar" Text="Cambiar Admin" CommandArgument='<%#Eval("username") %>' />
                <asp:LinkButton runat="server" id="borrar" CssClass="btn btn-danger" OnClientClick="ButtonBorrar" OnClick="ButtonBorrar" Text="Borrar" CommandArgument='<%#Eval("username") %>' />
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />

    <!-- Label que aparecerá cuando no haya usuarios -->
    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CarritoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.CarritoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Carritos </p>
    </div>

    <div style="min-height: 100vh">
        <!-- ListView para listar las Carritos de los Usuarios -->
        <asp:ListView runat="server" ID="listView">
            <GroupTemplate>
                <tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </tr>
            </GroupTemplate>

            <LayoutTemplate>
                <!-- table para mostrar los carritos -->
                <!-- Columnas: id, usuario, importe y opciones -->
                <table class="table table-hover border-bottom border-dark" style="padding-left: 20px;">
                    <thead class="thead-dark">
                        <tr>
                            <th>
                                Id
                            </th>
                            <th>
                                Usuario
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
                     <%# Eval("id") %>
                </td>
                <td>
                     <%# Eval("id_usuario") %>
                </td>
                <td>
                    <%# Eval("importe_total") %>€
                </td>
                <!-- Botón de ver carrito pasando el id de usuario -->
                <td>
                    <asp:LinkButton runat="server" ID="ver" CssClass="btn btn-primary" OnClientClick="ButtonVer" OnClick="ButtonVer" Text="Ver" CommandArgument='<%#Eval("id_usuario") %>' />
                </td>
            </ItemTemplate>
        </asp:ListView>
        <br />

        <!-- Label que aparecerá cuando no haya carritos -->
        <div style="width:100%; height: 100px; align-content:center; text-align:center">
            <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
        </div>
    </div>
</asp:Content>

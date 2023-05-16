<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CategoriaProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.CategoriaProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Géneros de Videojuegos </p>
        <asp:LinkButton runat="server" id="añadir" CssClass="btn btn-outline-success" OnClientClick="ButtonAñadir" OnClick="ButtonAñadir" Text="Añadir" />
    </div>

    <asp:ListView runat="server" ID="listView">
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </tr>
        </GroupTemplate>

        <LayoutTemplate>
            <table class="table table-hover">
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
                 <asp:Image ID="Image1" runat="server" Width="50px" Height="50px" ImageUrl='<%# Eval("imagen") %>' />	
            </td>
            <td>
                <%# Eval("nombre") %>
            </td>
            <td>
                <asp:LinkButton runat="server" id="editar" CssClass="btn btn-warning" OnClientClick="ButtonEditar" OnClick="ButtonEditar" Text="Editar" CommandArgument='<%#Eval("id") %>' />
                <asp:LinkButton runat="server" id="borrar" CssClass="btn btn-danger" OnClientClick="ButtonBorrar" OnClick="ButtonBorrar" Text="Borrar" CommandArgument='<%#Eval("id") %>' />
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

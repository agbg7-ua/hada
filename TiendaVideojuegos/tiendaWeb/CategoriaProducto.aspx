<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CategoriaProducto.aspx.cs" Inherits="tiendaWeb.CategoriaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Géneros de Videojuegos </p>
    </div>

    <!-- ListView para listar las Categorías de los Productos -->
    <div class= "col-auto text-center mx-auto" style="min-height: 100vh">

            <asp:ListView runat="server" ID="listView" GroupItemCount="6">

                <GroupTemplate>
                    <tr>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                    </tr>
                </GroupTemplate>

                <GroupSeparatorTemplate>
                    <tr id="Tr1" runat="server" visible="false">
                        <td colspan="3" style="padding: 5px 5px 5px 5px;"><hr /></td>
                    </tr>
                </GroupSeparatorTemplate>

                <LayoutTemplate>
                    <table>
                        <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
                    </table>
                </LayoutTemplate>

                <ItemTemplate>
                    <!-- Estilo card inspirado de Bootstrap -->
                    <td style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                        <!-- Todo el card redirige a la página de Productos de dicha Categoría utilizando HyperLink y pasándole el id de Categoría -->
                        <asp:HyperLink runat="server" ID="categoria" NavigateUrl='<%# "ListarProductoCategoría.aspx?idCat=" + Eval("id")%>' CssClass="text-dark">
                            <div class="card border border-dark" style="background-color: #c3c3c3; height: 550px;">
                                <!-- Imagen de la Categoría -->
                                <asp:Image ID="Image1" CssClass="" runat="server" Width="280px" Height="280px"
                                            ImageUrl='<%# Eval("imagen") %>' />
                                <!-- Mustra el nombre y la descripción de la Categoría -->
                                <div class="card-body table-responsive">
                                    <h5 class="card-title text-dark"> <%# Eval("nombre") %> </h5>
                                    <p class="card-text text-dark">  <%# Eval("descripcion") %> </p>
                                </div>
                            </div>
                        </asp:HyperLink>
                    </td>
                </ItemTemplate>
            </asp:ListView>
            <br />
            
            <!-- En caso de que no haya ninguna Categoría, se mostrará el Label -->
            <div style="width:100%; height: 100px; align-content:center; text-align:center">
                <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
            </div>
        </div>
</asp:Content>

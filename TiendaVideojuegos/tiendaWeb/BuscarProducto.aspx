<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="BuscarProducto.aspx.cs" Inherits="tiendaWeb.BuscarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <asp:Label runat="server" ID="titulo" Cssclass="font-weight-bold h2 text-center mx-auto text-white bg-dark"/>
    </div>

    <!-- ListView que enseñan los Productos encontrados por la búsqueda -->
    <div class= "col-auto text-center mx-auto" style="min-height: 100vh">
        <asp:ListView runat="server" ID="listView" GroupItemCount="6" OnItemDataBound="Buttons">

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
                <!-- Card inspirado en Bootstrap -->
                <td style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                    <div class="card border border-dark" style="height: 475px;">
                            <!-- Muestra la imagen del Producto -->
                            <asp:Image ID="Image1" CssClass="" runat="server" Width="280px" Height="280px"
                                        ImageUrl='<%# Eval("imagen") %>' />	
                            <!-- Muestra el nombre y el precio -->
                            <div class="card-body" style="background-color: #d6d5d5;">
                                <h5 class="card-title"> <%# Eval("nombre") %> </h5>
                                <p class="card-text">  <%# Eval("pvp") %>€ </p>
                                <!-- Ver producto redirige a la página de muestra del producto, pasándole su id -->
                                <a href='<%# "Producto.aspx?idProd=" + Eval("id")%>' class="btn btn-info">Ver Producto</a>
                                <!-- Botón de Comprar que hará un pedido de ese producto, por ello recoge el id del Producto -->
                                <asp:LinkButton runat="server" ID="comprar" CssClass="btn btn-success" Text="Comprar" OnClick="ButtonComprar" OnClientClick="ButtonComprar" CommandArgument='<%# Eval("id") %>'/>
                            </div>
                        </div>
                </td>
            </ItemTemplate>
        </asp:ListView>
        <br />
        <!-- En caso de que no se hayan encontrado productos, aparecerá el Label -->
        <div style="width:100%; height: 100px; align-content:center; text-align:center">
            <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarProducto.aspx.cs" Inherits="tiendaWeb.ListarProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Videojuegos </p>
        <!-- Drpdown con las opciones que dejan oredenar los Productos de determinadas formas -->
        <div class="dropdown">
            <asp:dropdownlist runat="server" id="ddlTest" CssClass="float-right btn btn-secondary dropdown-toggle" OnSelectedIndexChanged="ddlTest_SelectedIndexChanged" AutoPostBack="true"> 
                 <asp:listitem text="Ordenar por nombre ascendente" value="1" Selected="True"></asp:listitem>
                 <asp:listitem text="Ordenar por nombre descendente" value="2"></asp:listitem>
                 <asp:listitem text="Ordenar por precio ascendente" value="3"></asp:listitem>
                 <asp:listitem text="Ordenar por precio descendente" value="4"></asp:listitem>
            </asp:dropdownlist>
        </div>
    </div>

    <!-- Utilizamos ListView para listar los Productos -->
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
                    <!-- Estilo card inspirado de Bootstrap -->
                    <td style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                        <div class="card border border-dark" style="height: 475px;">
                            <!-- Imagen del Producto -->
                            <asp:Image ID="ProductImage" CssClass="" runat="server" Width="280px" Height="280px"
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

            <!-- Si no hay Productos, se muestra el Label -->
            <div style="width:100%; height: 100px; align-content:center; text-align:center">
                <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
            </div>
        </div>
</asp:Content>

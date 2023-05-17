<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CategoriaProducto.aspx.cs" Inherits="tiendaWeb.CategoriaProducto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Géneros de Videojuegos </p>
    </div>

    <div class= "col-auto text-center mx-auto">

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
                    <td style="width:300px; height:350px; padding: 5px 5px 5px 25px;">
                        <div class="card" style="background-color: #c3c3c3;">
                            <asp:Image ID="Image1" CssClass="" runat="server" Width="280px" Height="280px"
                                        ImageUrl='<%# Eval("imagen") %>' />	
                            <div class="card-body">
                                <h5 class="card-title"> <%# Eval("nombre") %> </h5>
                                <p class="card-text">  <%# Eval("descripcion") %> </p>
                                <a href='<%# "ListarProductoCategoría.aspx?idCat=" + Eval("id")%>' class="btn btn-info">Ver Productos</a>
                            </div>
                        </div>
                    </td>
                </ItemTemplate>
            </asp:ListView>
            <br />
            <div style="width:100%; height: 100px; align-content:center; text-align:center">
                <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
            </div>
        </div>
</asp:Content>

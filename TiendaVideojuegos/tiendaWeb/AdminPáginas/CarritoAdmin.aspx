<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="CarritoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.CarritoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Carrito </p>
    </div>

    <asp:ListView runat="server" ID="listView">
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </tr>
        </GroupTemplate>

        <LayoutTemplate>
            <table class="table table-hover" style="padding-left: 20px;">
                <thead class="thead-dark">
                    <tr>
                        <th>
                            Id línea
                        </th>
                        <th>
                            Id carrito
                        </th>
                        <th>
                            Id producto
                        </th>
                        <th>
                            Cantidad
                        </th>
                        <th>
                            Importe
                        </th>
                        <th>
                            Fecha
                        </th>
                    </tr>
                </thead>
                <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
            </table>
        </LayoutTemplate>

        <ItemTemplate>
            <td>
                 <%# Eval("id_línea") %>
            </td>
            <td>
                 <%# Eval("id_carrito") %>
            </td>
            <td>
                <%# Eval("id_producto") %>
            </td>
            <td>
                <%# Eval("cantidad") %>
            </td>
            <td>
                <%# Eval("importe") %>
            </td>
            <td>
                <%# Eval("fecha") %>
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

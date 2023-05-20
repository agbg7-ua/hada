﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LineaPedido.aspx.cs" Inherits="tiendaWeb.LineaPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="border border-white navbar navbar-expand-lg bg-dark">
        <asp:Label runat="server" ID="titulo" Cssclass="font-weight-bold h2 text-center mx-auto text-white bg-dark"/>
    </div>

    <asp:ListView runat="server" ID="listView" OnItemDataBound="ImagenProducto">
        <GroupTemplate>
            <tr>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
            </tr>
        </GroupTemplate>

        <LayoutTemplate>
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
                            Nombre de Producto
                        </th>
                        <th>
                            Cantidad
                        </th>
                        <th>
                            Importe
                        </th>
                    </tr>
                </thead>
                <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
            </table>
        </LayoutTemplate>

        <ItemTemplate>
            <td>
                 <%# Eval("id_linea") %>
            </td>
            <td>
                 <asp:Image ID="Image1" runat="server" Width="70px" Height="70px" ImageUrl="" />	
            </td>
            <td>
                 <asp:Label ID="nombre" runat="server" CssClass="label label-default" />
            </td>
            <td>
                <%# Eval("cantidad") %>
            </td>
            <td>
                <%# Eval("importe") %>€
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />
    <div class="" style="padding-left: 20px;">
        <asp:Label runat="server" ID="total" CssClass="font-weight-bold"></asp:Label>
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PedidoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.PedidoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Administración de Pedidos </p>
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
                            Id
                        </th>
                        <th>
                            Usuario
                        </th>
                        <th>
                            Fecha
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
                 <%# Eval("fecha") %>
            </td>
            <td>
                <%# Eval("importe_total") %>€
            </td>
            <td>
                <asp:LinkButton runat="server" ID="ver" CssClass="btn btn-primary" OnClientClick="ButtonVer" OnClick="ButtonVer" Text="Ver" CommandArgument='<%#Eval("id") %>' />
                <asp:LinkButton runat="server" ID="borrar" CssClass="btn btn-danger" OnClientClick="ButtonBorrar" OnClick="ButtonBorrar" Text="Borrar" CommandArgument='<%#Eval("id") %>' />
            </td>
        </ItemTemplate>
    </asp:ListView>
    <br />

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

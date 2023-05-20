<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="tiendaWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Pedidos </p>
        <div class="dropdown">
            <asp:dropdownlist runat="server" id="ddlTest" CssClass="float-right btn btn-secondary dropdown-toggle" OnSelectedIndexChanged="ddlTest_SelectedIndexChanged" AutoPostBack="true"> 
                 <asp:listitem text="Ordenar por precio ascendente" value="1" Selected="True"></asp:listitem>
                 <asp:listitem text="Ordenar por precio descendente" value="2"></asp:listitem>
            </asp:dropdownlist>
        </div>
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
                       <div class="card text-center border border-secondary rounded" style="width: 18rem; background-color: #c3c3c3;">
                          <div class="card-body">
                            <h5 class="card-title">Pedido nº <%# Eval("id") %></h5>
                            <p class="card-text"> Total pagado:
                                </br>
                                <%# Eval("importe_total") %>€</p>
                            <a href='<%# "LineaPedido.aspx?idPed=" + Eval("id")%>' class="btn btn-dark">Ver Contenido</a>
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

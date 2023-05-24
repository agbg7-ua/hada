<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListarProductoCategoría.aspx.cs" Inherits="tiendaWeb.ListarProductoCategoría" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <asp:Label runat="server" ID="titulo" Cssclass="font-weight-bold h2 text-center mx-auto text-white bg-dark"/>
        <div class="dropdown">
            <asp:dropdownlist runat="server" id="ddlTest" CssClass="float-right btn btn-secondary dropdown-toggle" OnSelectedIndexChanged="ddlTest_SelectedIndexChanged" AutoPostBack="true"> 
                 <asp:listitem text="Ordenar por nombre ascendente" value="1" Selected="True"></asp:listitem>
                 <asp:listitem text="Ordenar por nombre descendente" value="2"></asp:listitem>
                 <asp:listitem text="Ordenar por precio ascendente" value="3"></asp:listitem>
                 <asp:listitem text="Ordenar por precio descendente" value="4"></asp:listitem>
            </asp:dropdownlist>
        </div>
    </div>

     <div class= "col-auto text-center mx-auto">

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
                    <td style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                        <div class="card border border-dark" style="height: 475px;">
                            <asp:Image ID="Image1" CssClass="" runat="server" Width="280px" Height="280px"
                                        ImageUrl='<%# Eval("imagen") %>' />	
                            <div class="card-body" style="background-color: #d6d5d5;">
                                <h5 class="card-title"> <%# Eval("nombre") %> </h5>
                                <p class="card-text">  <%# Eval("pvp") %>€ </p>
                                <a href='<%# "Producto.aspx?idProd=" + Eval("id")%>' class="btn btn-info">Ver Producto</a>
                                <asp:LinkButton runat="server" ID="comprar" CssClass="btn btn-success" Text="Comprar" OnClick="ButtonComprar" OnClientClick="ButtonComprar" CommandArgument='<%# Eval("id") %>'/>
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

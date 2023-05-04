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
                        <div class="productItem">
                            <asp:HyperLink ID="HyperLink1" runat="server" 
                                NavigateUrl="#">
                                <div>
                                    <asp:Image ID="ProductImage" runat="server" Width="200px" Height="200px"
                                        ImageUrl='<%# Eval("imagen") %>' />	
                                </div>
                                <div>
                                    <b class="font-weight-bold text-dark h5"> 
                                        <%# Eval("nombre") %>
                                    </b>
                                </div>
                                <div>
                                    <b class="font-weight-bold text-dark h5"> 
                                        <%# Eval("pvp") %>
                                    </b>
                                </div>
                            </asp:HyperLink>
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

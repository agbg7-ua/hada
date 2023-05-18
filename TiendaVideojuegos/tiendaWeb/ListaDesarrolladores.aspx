<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ListaDesarrolladores.aspx.cs" Inherits="tiendaWeb.ListaDesarrolladores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/bootstrap.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark">Desarrolladoras de videojuegos </p>
    </div>

    <h2 cssclass="h2" style="margin-left: 50px">Filtrar</h2>
    <div>


        <asp:Label ID="Label2" runat="server" Text="Nombre " Font-Bold="true" Font-Size="Large" Style="margin-left: 50px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text="Fecha " Font-Bold="true" Font-Size="Large"></asp:Label>
        <asp:TextBox ID="TextBox_Date" runat="server" TextMode="Date"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="Pais de origen" Font-Bold="true" Font-Size="Large"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

    </div>

    <%--    <asp:table runat="server" xmlns:asp="#unknown">
        <asp:tablerow>
            <asp:tablecell columnspan="2">
                <asp:image runat="server" imageurl="Imagenes/gustav.png" height="120px" width="120px"></asp:image>
            </asp:tablecell>
            <asp:tablecell columnspan="2">
                <asp:label runat="server" text="Nombre: " font-bold="true"></asp:label>
                <asp:label id="label_nombre" runat="server" text='<%#Eval("Nombre") %>'></asp:label>
                <br />
                <asp:label runat="server" text="Fecha de creacion: " font-bold="true"></asp:label>
                <asp:label id="label_fecha" runat="server" text='<%#Eval("Fecha") %>'></asp:label>
                <br />
                <asp:label runat="server" text="Pais de origen: " font-bold="true"></asp:label>
                <asp:label id="label_pais" runat="server" text='<%#Eval("Pais") %>'></asp:label>
            </asp:tablecell>
        </asp:tablerow>

    </asp:table>--%>

    <div class="col-auto text-center mx-auto">
        <asp:ListView runat="server" ID="ListView1" GroupItemCount="2">

            <GroupTemplate>
                <tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </tr>
            </GroupTemplate>

            <%--            <GroupSeparatorTemplate>
                <tr id="Tr1" runat="server" visible="false">
                    <td colspan="3" style="padding: 5px 5px 5px 5px;">
                        <hr />
                    </td>
                </tr>
            </GroupSeparatorTemplate>--%>

            <LayoutTemplate>
                <table>
                    <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <td style="width: 300px; height: 350px; padding: 5px 5px 5px 25px;">
                    <div class="productItem">


                        <asp:table runat="server" xmlns:asp="#unknown" width="500">
                            <asp:tablerow>
                                <asp:tablecell columnspan="2">
<%--                                    <asp:hyperlink id="HyperLink1" runat="server"
                                        navigateurl='<%# "Desarrollador.aspx"%>'>
                                        <asp:image runat="server" imageurl='<%#Eval("imagen") %>' height="120px" width="120px"></asp:image>
                                    </asp:hyperlink>--%>
                                    <asp:imagebutton id="boton_lista" runat="server" imageurl='<%#Eval("imagen") %>'  height="120px" width="120px" OnClick="test" CommandArgument='<%# Eval("nombre") %>'></asp:imagebutton>

                                </asp:tablecell>
                                <asp:tablecell columnspan="2">
                                    <asp:label runat="server" text="Nombre: " font-bold="true"></asp:label>
                                    <asp:hyperlink id="HyperLink2" runat="server"
                                        navigateurl='<%# "Desarrollador.aspx"%>'>
                                        <asp:label id="label_nombre" runat="server" text='<%#Eval("nombre") %>'></asp:label>
                                    </asp:hyperlink>
                                    <br />
                                    <asp:label runat="server" text="Fecha de creacion: " font-bold="true"></asp:label>
                                    <asp:label id="label_fecha" runat="server" text='<%#Eval("web") %>'></asp:label>
                                    <br />
                                    <asp:label runat="server" text="Pais de origen: " font-bold="true"></asp:label>
                                    <asp:label id="label_pais" runat="server" text='<%#Eval("origen") %>'></asp:label>
                                </asp:tablecell>
                            </asp:tablerow>

                        </asp:table>

                    </div>
                </td>
            </ItemTemplate>
        </asp:ListView>
        <asp:Label ID="Label_error" runat="server" Text=""></asp:Label>
        <br />
        <div style="width: 100%; height: 100px; align-content: center; text-align: center">
            <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron desarrolladores, intentelo más tarde." Visible="false"></asp:Label>
        </div>
    </div>
</asp:Content>

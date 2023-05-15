<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Desarrrolador.aspx.cs" Inherits="tiendaWeb.Desarrrolador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/bootstrap.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark">Desarrollador </p>
    </div>

    <div class="container">

        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Image ID="Image3" runat="server" Height="300" Width="200" Style="margin-right: 30px" />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" CssClass="bg-dark"/>
                    <br />
                    <asp:Button ID="Button_upload_image" runat="server" Text="Upload" OnClick="Button_upload_image_click" Visible="false" CssClass="btn"/>

                </asp:TableCell>
                <asp:TableCell>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Nombre: " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label_nombre" runat="server" Text="Label_nombre"></asp:Label>
                        <%--<asp:TextBox ID="TextBox_nombre" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="form-control input-lg"></asp:TextBox>--%>
                        <asp:TextBox ID="TextBox_nombre" Visible="false" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="form-control input-lg"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_nombre" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />


                        <asp:Label ID="Label2" runat="server" Text="Descripcion: " Font-Bold="true"></asp:Label>
                        <br />
                        <asp:Label ID="Label_descripcion" runat="server" Text="asdasd" Width="800px"></asp:Label>

                        <asp:TextBox ID="TextBox_descripcion" runat="server" OnTextChanged="TextBox_descripcion_TextChanged" TextMode="MultiLine" Visible="false" Height="172px" Width="716px" CssClass="form-control input-lg"></asp:TextBox>
                        <br />
                        <br />

                        <asp:Label ID="Label3" runat="server" Text="Origen: " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label_origen" runat="server" Text="Label_oringen"></asp:Label>
                        <asp:TextBox ID="TextBox_origen" runat="server" CssClass="form-control input-lg" Visible="false"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_origen" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Fecha de creacion: " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label_fecha" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox_fecha" runat="server" CssClass="form-control input-lg" Visible="false"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_fecha" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Label ID="Label9" runat="server" Text="Website: " Font-Bold="true"></asp:Label>
                        <asp:Label ID="Label_web" runat="server" Text="Label"></asp:Label>
                        <asp:TextBox ID="TextBox_web" runat="server" CssClass="form-control input-lg" Visible="false"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_web" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                    </div>

                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

        <%--<asp:Image ID="Image2" runat="server" ImageUrl="Imagenes/gustav.png" Height="400" Width="300" />--%>


        <br />
        <br />

        <asp:Button ID="Button_editar" runat="server" Text="Editar" OnClick="Button_editar_Click" CssClass="btn" />
        <asp:Button ID="Button_eliminar" runat="server" Text="Eliminar" CssClass="btn" Enabled="false" />
        <asp:Button ID="Button_nuevo" runat="server" Text="Nuevo" CssClass="btn" OnClick="Button_nuevo_click" />
        <asp:Button ID="Button_agregar_imagen" runat="server" Text="Agregar Imagen" CssClass="btn" Visible="false" Enabled="false" />
        <asp:Button ID="Button_cancelar" runat="server" Text="Cancelar" OnClick="cancelar_click" CssClass="btn" />

        <br />
        <asp:Label ID="Label_error_info" runat="server" Text="" ForeColor="#990000"></asp:Label>


        <br />
        <br />
        <%--<asp:Label ID="Label5" runat="server" Text="Titulos: "></asp:Label>--%>
        <h3>Titulos</h3>
        <br />
        <%--    <asp:Image ID="Image1" runat="server" ImageUrl="Imagenes/gustav.png" />--%>
        <%--        <asp:GridView ID="GridView1" runat="server"></asp:GridView>--%>
        <%--        <asp:ListView ID="ListView1" runat="server">
            <ItemTemplate>
                <div class="col-sm-3 col-xs-12">
                <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ImageUrl") %>' Height="200" Width="150" />
                <asp:Label ID="Label4" runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                <br />
                </div>
            </ItemTemplate>
        </asp:ListView>--%>
        <asp:ListView runat="server" ID="ListView1" GroupItemCount="6">

            <GroupTemplate>
                <tr>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </tr>
            </GroupTemplate>

            <GroupSeparatorTemplate>
                <tr id="Tr1" runat="server" visible="false">
                    <td colspan="3" style="padding: 5px 5px 5px 5px;">
                        <hr />
                    </td>
                </tr>
            </GroupSeparatorTemplate>

            <LayoutTemplate>
                <table>
                    <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <td style="width: 300px; height: 350px; padding: 5px 5px 5px 25px;">
                    <div class="productItem">
                        <asp:HyperLink ID="HyperLink1" runat="server"
                            NavigateUrl='<%# "Producto.aspx"%>'>
                            <div class="col-sm-4">
                                <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("ImageUrl") %>' Height="200" Width="150" />
                            </div>
                            <div>
                                <asp:Label ID="Label4" runat="server" Text='<%#Eval("Title") %>'></asp:Label>
                            </div>
                        </asp:HyperLink>
                    </div>
                </td>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>

<%--https://stackoverflow.com/questions/6801817/asp-net-listview-control-template--%>
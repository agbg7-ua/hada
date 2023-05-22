<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarDesarrolladorAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.EditarDesarrolladorAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

            <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Image ID="ProductImage" runat="server"  Width="350px" Height="350px" CssClass="img-thumbnail" Style="margin-right: 30px" />
                    <br />
                    <asp:FileUpload ID="FileUpload1" runat="server" Visible="true" CssClass="form-control input-group-sm"/>
                    <br />
                    <asp:Button ID="Button_upload_image" runat="server" Text="Upload Image" OnClick="Button_upload_image_Click" Visible="true" CssClass="btn"/>

                </asp:TableCell>
                <asp:TableCell>
                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Nombre: " Font-Bold="true"></asp:Label>

                        <%--<asp:TextBox ID="TextBox_nombre" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="form-control input-lg"></asp:TextBox>--%>
                        <asp:TextBox ID="TextBox_nombre" OnTextChanged="TextBox_nombre_TextChanged" Visible="true" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_nombre" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />


                        <asp:Label ID="Label2" runat="server" Text="Descripcion: " Font-Bold="true"></asp:Label>
                        <br />

                        <asp:TextBox ID="TextBox_descripcion" runat="server" TextMode="MultiLine" Visible="true" Height="172px" Width="716px" CssClass="form-control input-lg"></asp:TextBox>
                        <br />
                        <br />

                        <asp:Label ID="Label3" runat="server" Text="Origen: " Font-Bold="true"></asp:Label>

                        <asp:TextBox ID="TextBox_origen" runat="server" CssClass="form-control input-lg" Visible="true"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_origen" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Label ID="Label7" runat="server" Text="Fecha de creacion: " Font-Bold="true"></asp:Label>

                        <asp:TextBox ID="TextBox_fecha" runat="server" CssClass="form-control input-lg" Visible="true"></asp:TextBox>
                        <asp:TextBox ID="TextBox_Date" runat="server" TextMode="Date"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_fecha" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Label ID="Label9" runat="server" Text="Website: " Font-Bold="true"></asp:Label>

                        <asp:TextBox ID="TextBox_web" runat="server" CssClass="form-control input-lg" Visible="true"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_web" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
                    </div>

                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    <asp:Button ID="Button_guardar" OnClick="Button_guardar_Click" runat="server" Text="Guardar" Enabled="true" CssClass="btn"/>
    <asp:Button ID="Button_cancelar" OnClick="Button_cancelar_Click" runat="server" Text="Cancelar" Enabled="true" CssClass="btn"/>
    <asp:Button ID="Button_recargar" OnClick="Button_recargar_Click" runat="server" Text="Recargar datos" Enabled="true" CssClass="btn" />
<%--    <asp:Button ID="Button3" runat="server" Text="Button" />
    <asp:Button ID="Button4" runat="server" Text="Button" />
    <asp:Button ID="Button5" runat="server" Text="Button" />--%>



    <div style="padding-left:40px;">
        <asp:Button runat="server" id="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron desarrolladores, intentelo más tarde." Visible="false" ></asp:Label>
    </div>
    <asp:Label ID="Label_info" runat="server" Text="Label"></asp:Label>
</asp:Content>

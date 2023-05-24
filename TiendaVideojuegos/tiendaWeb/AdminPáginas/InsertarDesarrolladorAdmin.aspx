<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InsertarDesarrolladorAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.InsertarDesarrolladorAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Table ID="Table1" runat="server">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Image ID="ProductImage" runat="server" Width="350px" Height="350px" CssClass="img-thumbnail" Style="margin-right: 30px" />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" Visible="true" CssClass="form-control input-group-sm" />
                <br />
                <asp:Button ID="Button_upload_image" runat="server" Text="Upload Image" OnClick="Button_upload_image_Click" Visible="true" CssClass="btn" />

            </asp:TableCell>
            <asp:TableCell>
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Nombre: " Font-Bold="true"></asp:Label>

                    <%--<asp:TextBox ID="TextBox_nombre" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="form-control input-lg"></asp:TextBox>--%>
                    <asp:TextBox ID="TextBox_nombre" OnTextChanged="TextBox_nombre_TextChanged" Visible="true" runat="server" CssClass="form-control input-lg"></asp:TextBox>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_nombre" ValidationExpression="^.*$"></asp:RegularExpressionValidator>--%>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El Nombre contiene caracteres no validos" ControlToValidate="TextBox_nombre" ValidationExpression="^[a-zA-Z0-9_ ]*$" Font-Bold="True" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Se requiere un Nombre para el registro" ControlToValidate="TextBox_nombre" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <br />


                    <asp:Label ID="Label2" runat="server" Text="Descripcion: " Font-Bold="true"></asp:Label>
                    <br />

                    <asp:TextBox ID="TextBox_descripcion" runat="server" TextMode="MultiLine" Visible="true" Height="172px" Width="716px" CssClass="form-control input-lg" ControlToValidate="TextBox_descripcion"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="La descripcion es requerida para el registro" ControlToValidate="TextBox_descripcion" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />

                    <asp:Label ID="Label3" runat="server" Text="Origen: " Font-Bold="true"></asp:Label>

                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Estados Unidos</asp:ListItem>
                        <asp:ListItem>Canada</asp:ListItem>
                        <asp:ListItem>Mexico</asp:ListItem>
                        <asp:ListItem>Inglaterra</asp:ListItem>
                        <asp:ListItem>Francia</asp:ListItem>
                        <asp:ListItem>Alemania</asp:ListItem>
                        <asp:ListItem>Italia</asp:ListItem>
                        <asp:ListItem>España</asp:ListItem>
                        <asp:ListItem>China</asp:ListItem>
                        <asp:ListItem>Japon</asp:ListItem>
                        <asp:ListItem>Corea del Sur</asp:ListItem>
                        <asp:ListItem>Australia</asp:ListItem>
                        <asp:ListItem>Brasil</asp:ListItem>
                        <asp:ListItem>Argentina</asp:ListItem>
                        <asp:ListItem>Chile</asp:ListItem>
                        <asp:ListItem>Colombia</asp:ListItem>
                        <asp:ListItem>Peru</asp:ListItem>
                        <asp:ListItem>Venezuela</asp:ListItem>
                        <asp:ListItem>Uruguay</asp:ListItem>
                        <asp:ListItem>Paraguay</asp:ListItem>
                        <asp:ListItem>Ecuador</asp:ListItem>
                        <asp:ListItem>Bolivia</asp:ListItem>
                        <asp:ListItem>Costa Rica</asp:ListItem>
                        <asp:ListItem>Panama</asp:ListItem>
                        <asp:ListItem>El Salvador</asp:ListItem>
                        <asp:ListItem>Honduras</asp:ListItem>
                        <asp:ListItem>Nicaragua</asp:ListItem>
                        <asp:ListItem>Guatemala</asp:ListItem>
                        <asp:ListItem>Belgica</asp:ListItem>
                        <asp:ListItem>Portugal</asp:ListItem>
                        <asp:ListItem>Irlanda</asp:ListItem>
                        <asp:ListItem>Suiza</asp:ListItem>
                        <asp:ListItem>Suecia</asp:ListItem>
                        <asp:ListItem>Noruega</asp:ListItem>
                        <asp:ListItem>Dinamarca</asp:ListItem>
                        <asp:ListItem>Finlandia</asp:ListItem>
                        <asp:ListItem>Polonia</asp:ListItem>
                        <asp:ListItem>Rusia</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Es necesario poner un pais de origen" ControlToValidate="DropDownList1" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>

                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_origen" ValidationExpression="^.*$"></asp:RegularExpressionValidator>--%>
                    <br />
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Fecha de creacion: " Font-Bold="true"></asp:Label>

                    <%--<asp:TextBox ID="TextBox_fecha" runat="server" CssClass="form-control input-lg" Visible="true"></asp:TextBox>--%>
                    <asp:TextBox ID="TextBox_Date" runat="server" TextMode="Date"></asp:TextBox>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_fecha" ValidationExpression="^.*$"></asp:RegularExpressionValidator>--%>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="La fecha de creacion es necesaria para el registro" ControlToValidate="TextBox_Date" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="Label9" runat="server" Text="Website: " Font-Bold="true"></asp:Label>

                    <asp:TextBox ID="TextBox_web" runat="server" CssClass="form-control input-lg" Visible="true"></asp:TextBox>
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Formato incorrecto para la web" ControlToValidate="TextBox_web" ValidationExpression="^\s*((?:https?://)?(?:[\w-]+\.)+[\w-]+)(/[\w ./?%&=-]*)?\s*$" Font-Bold="True" ForeColor="Red"></asp:RegularExpressionValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Es necesaria una web para el registro" ControlToValidate="TextBox_web" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                    <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_web" ValidationExpression="^((https?):\/\/)?(www.)?[a-z0-9]+\.[a-z]+(\/[a-zA-Z0-9#]+\/?)*$"></asp:RegularExpressionValidator>--%>
                </div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#FFCCCC" />
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Button ID="Button_guardar" OnClick="Button_guardar_Click" runat="server" Text="Guardar" Enabled="true" CssClass="btn" />
    <asp:Button ID="Button_cancelar" OnClick="Button_cancelar_Click" runat="server" Text="Cancelar" Enabled="true" CssClass="btn" />
    <%--<asp:Button ID="Button_recargar" OnClick="Button_recargar_Click" runat="server" Text="Recargar datos" Enabled="true" CssClass="btn" />--%>
    <%--    <asp:Button ID="Button3" runat="server" Text="Button" />
    <asp:Button ID="Button4" runat="server" Text="Button" />
    <asp:Button ID="Button5" runat="server" Text="Button" />--%>



    <div style="padding-left: 40px;">
        <asp:Button runat="server" ID="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
    </div>
    <div style="width: 100%; height: 100px; align-content: center; text-align: center">
        <asp:Label CssClass="labelVacio" runat="server" ID="Label_info" Text="" Visible="true" Font-Bold="true"></asp:Label>
    </div>
<%--    <div style="width: 100%; height: 100px; align-content: center; text-align: center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron desarrolladores, intentelo más tarde." Visible="false"></asp:Label>
    </div>--%>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarCategoriaProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.EditarCategoriaProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Editar Género </p>
    </div>

    <br />

    <div style="min-height: 100vh">
        <!-- Mostramos los datos de la categoría a editar (placeholders) con sus correspondientes TextBox para rellenar los campos -->
         <div class="container-fluid align-content-center" style="width: 700px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
            <ItemTemplate>
                <div class="form">
                    <!-- Nombre de la categoría -->
                    <label class="card-text font-weight-bold h4"> Nombre del Género: </label>
                    <asp:TextBox runat="server" ID="nombre" CssClass="form-control" placeholder="" TextMode="SingleLine"></asp:TextBox>
                    <!-- Validación -->
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="nombre" ErrorMessage="El nombre debe contener caracteres alfanuméricos y no debe superar los 45 caracteres" ValidationExpression="[a-zA-Z0-9' ']{1,45}$"></asp:RegularExpressionValidator>
                    </div>              
                    <br/>
                    <!-- Descripción de la categoría -->
                    <label class="card-text font-weight-bold h4"> Descripción: </label>
                    <asp:TextBox runat="server" ID="descripcion" CssClass="form-control" placeholder="" TextMode="MultiLine"></asp:TextBox>
                    <br/>
                </div>
            </ItemTemplate>

             <!-- Botones de volver y guardar -->
            <asp:Button runat="server" id="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
            <asp:LinkButton runat="server" id="guardar" CssClass="btn btn-warning" OnClientClick="ButtonGuardar" OnClick="ButtonGuardar" Text="Guardar" />
        </div>

        <!-- Mostramos los mensajes de Validación en caso de haber alguno -->
        <div class="container-fluid align-content-center" style="width: 700px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
            <div class="alert alert-danger" role="alert">
                <p class="message">
                    <asp:Label ID="Msg" runat="server" ></asp:Label>
                    <asp:ValidationSummary ID="ValidationS" runat="server" DisplayMode="BulletList" font-size="Small" />
                </p>
            </div>
        </div>
    </div>
</asp:Content>

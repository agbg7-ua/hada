<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InsertarCategoriaProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.InsertarCategoriaProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Nuevo Género </p>
    </div>
    
    <br />
    
    <div class="container-fluid align-content-center border border-secondary" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
        <ItemTemplate>
            <div class="form">
                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" ID="nombre" TextMode="SingleLine" CssClass="form-control"></asp:TextBox>
                    <label for="nombre">Nombre del Género</label>
                    <div class="invalid-feedback">
                        <asp:requiredfieldvalidator id="nombrevacio" runat="server" ControlToValidate="nombre" ErrorMessage="Nombre del Género es un campo obligatorio" SetFocusOnError="true" Display="Dynamic"></asp:requiredfieldvalidator>
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="nombre" ErrorMessage="El nombre debe contener caracteres alfanuméricos y no debe superar los 45 caracteres" ValidationExpression="[a-zA-Z0-9' ']{1,45}$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" ID="descripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                    <label for="decripcion">Descripción</label>
                    <div class="invalid-feedback">
                        <asp:requiredfieldvalidator id="descvacio" runat="server" ControlToValidate="descripcion" ErrorMessage="Descripción es un campo obligatorio"></asp:requiredfieldvalidator>
                    </div>
                </div>
                <div class="mb-3">
                    <small id="imagen" class="form-text text-muted">Imagen del Género</small>
                    <input class="form-control" type="file" name="FileUpload" id="formFile"/>
                </div>
            </div>
            <br />
            <asp:Button ID="guardar" Text="Guardar" runat="server" OnClick="ButtonGuardar" OnClientClick="ButtonGuardar" CssClass="btn btn-success"/>
            <asp:Button ID="volver" Text="Volver" runat="server" OnClick="ButtonVolver" OnClientClick="ButtonVolver" CssClass="btn btn-secondary"/>
        </ItemTemplate>
    </div>

    <div class="container-fluid align-content-center" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
        <div class="alert alert-danger" role="alert" id="alerta" runat="server">
            <p class="message">
                <asp:Label ID="Msg" runat="server" ></asp:Label>
                <asp:ValidationSummary ID="ValidationS" runat="server" DisplayMode="BulletList" font-size="Small" />
            </p>
        </div>
    </div>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InsertarProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.InsertarProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Nuevo Videojuego </p>
    </div>
    
    <br />
    
    <div class="container-fluid align-content-center border border-secondary" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
        <ItemTemplate>
            <div class="form">
                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" ID="nombre" TextMode="SingleLine" CssClass="form-control"></asp:TextBox>
                    <label for="nombre">Nombre del Videojuego</label>
                    <div class="invalid-feedback">
                        <asp:requiredfieldvalidator id="nombrevacio" runat="server" ControlToValidate="nombre" ErrorMessage="Nombre de Videojuego es un campo obligatorio" SetFocusOnError="true" Display="Dynamic"></asp:requiredfieldvalidator>
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="nombre" ErrorMessage="El nombre debe contener caracteres alfanuméricos y no debe superar los 45 caracteres" ValidationExpression="[a-zA-Z0-9]{1,45}$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" ID="pvp" CssClass="form-control" TextMode="Number" step="0.01" min="0"></asp:TextBox>
                    <label for="pvp">Precio</label>
                    <div class="invalid-feedback">
                        <asp:requiredfieldvalidator id="preciovacio" runat="server" ControlToValidate="pvp" ErrorMessage="Precio es un campo obligatorio"></asp:requiredfieldvalidator>
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="pvp" ErrorMessage="El precio no es válido" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="form-floating mb-3">
                    <asp:TextBox runat="server" ID="descripcion" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
                    <label for="decripcion">Descripción</label>
                    <div class="invalid-feedback">
                        <asp:requiredfieldvalidator id="descvacio" runat="server" ControlToValidate="descripcion" ErrorMessage="Descripción es un campo obligatorio"></asp:requiredfieldvalidator>
                    </div>
                </div>
                <div>
                    <small id="cat" class="form-text text-muted">Género</small>
                    <asp:DropDownList runat="server" ID="categoria" CssClass="form-select">

                    </asp:DropDownList>
                </div>
                <div>
                    <small id="des" class="form-text text-muted">Desarrolladora</small>
                    <asp:DropDownList runat="server" ID="desarrollador" CssClass="form-select">

                    </asp:DropDownList>
                </div>
                <div>
                    <small id="clas" class="form-text text-muted">Clasificación</small>
                    <asp:DropDownList runat="server" ID="clasificacion" CssClass="form-select">
                        <asp:listitem text="Pegi 3" value="1"></asp:listitem>
                        <asp:listitem text="Pegi 7" value="2" ></asp:listitem>
                        <asp:listitem text="Pegi 12" value="3"></asp:listitem>
                        <asp:listitem text="Pegi 16" value="4"></asp:listitem>
                        <asp:listitem text="Pegi 18" value="5"></asp:listitem>
                    </asp:DropDownList>
                </div>
                <div class="mb-3">
                    <small id="imagen" class="form-text text-muted">Imagen del Videojuego</small>
                    <input class="form-control" type="file" name="FileUpload" id="formFile"/>
                </div>
                <div class="form-check form-switch">
                    <input runat="server" class="form-check-input" type="checkbox" id="mostrar">
                    <label class="form-check-label" for="mostrar">Mostrar</label>
                </div>
            </div>
            <br />
            <asp:Button ID="guardar" Text="Guardar" runat="server" OnClick="ButtonGuardar" OnClientClick="ButtonGuardar" CssClass="btn btn-success"/>
            <asp:Button ID="volver" Text="Volver" runat="server" OnClick="ButtonVolver" OnClientClick="ButtonVolver" CssClass="btn btn-secondary"/>
        </ItemTemplate>
    </div>

    <div class="container-fluid align-content-center" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
        <div class="alert alert-danger" role="alert">
            <p class="message">
                <asp:Label ID="Msg" runat="server" ></asp:Label>
                <asp:ValidationSummary ID="ValidationS" runat="server" DisplayMode="BulletList" font-size="Small" />
            </p>
        </div>

        <div class="alert alert-warning" role="alert">
            <p class="message">
                <asp:Label ID="tarde" runat="server" Visible="false"></asp:Label>
            </p>
        </div>
    </div>

</asp:Content>

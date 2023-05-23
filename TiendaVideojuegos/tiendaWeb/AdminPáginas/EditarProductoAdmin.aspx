<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.EditarProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Editar Videojuego </p>
    </div>

    <br />

     <div class="container-fluid align-content-center" style="width: 700px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
        <ItemTemplate>
            <div class="form">
                <label class="card-text font-weight-bold h4"> Nombre del Videojuego: </label>
                <asp:TextBox runat="server" ID="nombre" CssClass="form-control" placeholder="" TextMode="SingleLine"></asp:TextBox>
                <div class="invalid-feedback">
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="nombre" ErrorMessage="El nombre debe contener caracteres alfanuméricos y no debe superar los 45 caracteres" ValidationExpression="[a-zA-Z0-9' ']{1,45}$"></asp:RegularExpressionValidator>
                </div>
                <br/>
                <label class="card-text font-weight-bold h4"> Precio: </label>
                <asp:TextBox runat="server" ID="pvp" CssClass="form-control" placeholder="" Width="300px" TextMode="Number" step="0.01" min="0"></asp:TextBox>
                <div class="invalid-feedback">
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="pvp" ErrorMessage="El precio no es válido" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                </div>
                <br />
                <div>
                    <label class="card-text font-weight-bold h4"> Género: </label>
                    <asp:DropDownList runat="server" ID="categoria" CssClass="form-select">

                    </asp:DropDownList>
                </div>
                <br />
                <div>
                    <label class="card-text font-weight-bold h4"> Desarrolladora: </label>
                    <asp:DropDownList runat="server" ID="desarrollador" CssClass="form-select">

                    </asp:DropDownList>
                </div>
                <br/>
                <div>
                    <label class="card-text font-weight-bold h4"> Clasificación: </label>
                    <asp:DropDownList runat="server" ID="clasificacion" CssClass="form-select">
                        <asp:listitem text="Pegi 3" value="1"></asp:listitem>
                        <asp:listitem text="Pegi 7" value="2" ></asp:listitem>
                        <asp:listitem text="Pegi 12" value="3"></asp:listitem>
                        <asp:listitem text="Pegi 16" value="4"></asp:listitem>
                        <asp:listitem text="Pegi 18" value="5"></asp:listitem>
                    </asp:DropDownList>
                </div>
                <br />
                <label class="card-text font-weight-bold h4"> Descripción: </label>
                <asp:TextBox runat="server" ID="descripcion" CssClass="form-control" placeholder="" TextMode="MultiLine"></asp:TextBox>
                <br/>
                <div class="form-check form-switch">
                    <input runat="server" class="form-check-input" type="checkbox" id="mostrar">
                    <label class="form-check-label" for="mostrar">Mostrar</label>
                </div>
                <br/>
            </div>
        </ItemTemplate>

        <asp:Button runat="server" id="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
        <asp:LinkButton runat="server" id="guardar" CssClass="btn btn-warning" OnClientClick="ButtonGuardar" OnClick="ButtonGuardar" Text="Guardar" />
    </div>

    <div class="container-fluid align-content-center" style="width: 700px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;" id="alerta" runat="server">
        <div class="alert alert-danger" role="alert">
            <p class="message">
                <asp:Label ID="Msg" runat="server" ></asp:Label>
                <asp:ValidationSummary ID="ValidationS" runat="server" DisplayMode="BulletList" font-size="Small" />
            </p>
        </div>
    </div>

</asp:Content>

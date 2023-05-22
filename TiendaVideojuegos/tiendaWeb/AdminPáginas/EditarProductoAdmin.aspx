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
                <asp:TextBox runat="server" ID="nombre" CssClass="form-control" placeholder=""></asp:TextBox>
                <div class="invalid-feedback">
                    <asp:requiredfieldvalidator id="nombrevacio" runat="server" ControlToValidate="nombre" ErrorMessage="Nombre del Videojuego es un campo obligatorio" SetFocusOnError="true" Display="Dynamic"></asp:requiredfieldvalidator>
                    <asp:RegularExpressionValidator runat="server" ControlToValidate="nombre" ErrorMessage="El nombre debe contener caracteres alfanuméricos y no debe superar los 45 caracteres" ValidationExpression="[a-zA-Z0-9' ']{1,45}$"></asp:RegularExpressionValidator>
                </div>
                <br/>
                 <div class="form-floating mb-3" style="padding-left: 20px;">
                    <label class="card-text font-weight-bold h4"> Precio: </label>
                    <asp:TextBox runat="server" ID="pvp" CssClass="form-control" placeholder="" Width="300px" TextMode="Number" step="0.01" min="0"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:requiredfieldvalidator id="preciovacio" runat="server" ControlToValidate="pvp" ErrorMessage="Precio es un campo obligatorio"></asp:requiredfieldvalidator>
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="pvp" ErrorMessage="El precio no es válido" ValidationExpression="^\d*\.?\d*$"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br />
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
                <p class="font-weight-bold text-dark h5"> Descripción: 
                </p>
                <div class="form-group">
                    <asp:TextBox runat="server" ID="descripcion" class="form-control" Width="500px" Height="150px" placeholder="" ></asp:TextBox>
                </div>
            
            </div>
        </ItemTemplate>

        <asp:Button runat="server" id="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
        <asp:LinkButton runat="server" id="guardar" CssClass="btn btn-warning" OnClientClick="ButtonGuardar" OnClick="ButtonGuardar" Text="Guardar" />

    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

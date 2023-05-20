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
                    <asp:TextBox runat="server" ID="nombre" TextMode="SingleLine" placeholder="Nombre del Videojuego" CssClass="form-control"></asp:TextBox>
                    <asp:requiredfieldvalidator id="nombrevacio" runat="server" ControlToValidate="nombre" ErrorMessage="Nombre de Videojuego es un campo obligatorio" SetFocusOnError="True"></asp:requiredfieldvalidator>
                </div>
                <div class="form-floating mb-3">
                    <input runat="server"  type="number" step="0.01" min="0" class="form-control" id="pvp" placeholder="Precio">
                    <label for="pvp">Precio</label>
                </div>
                <div class="form-floating mb-3">
                    <textarea runat="server" id="descripcion" class="form-control" placeholder="Descripción"></textarea>
                    <label for="decripcion">Descripción</label>
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
                    <br />
                    <asp:Label ID = "lblMessage" Text="File uploaded successfully." runat="server" ForeColor="Green" Visible="false" />
                </div>
                <div class="form-check form-switch">
                    <input runat="server" class="form-check-input" type="checkbox" id="mostrar">
                    <label class="form-check-label" for="mostrar">Mostrar</label>
                </div>
            </div>
            <asp:Button ID="guardar" Text="Guardar" runat="server" OnClick="ButtonGuardar" OnClientClick="ButtonGuardar" CssClass="btn btn-success"/>
        </ItemTemplate>
    </div>

    <p class="message">
        <asp:Label ID="Msg" runat="server"></asp:Label>
        <asp:ValidationSummary ID="ValidationS" runat="server" DisplayMode="BulletList" font-size="Small" />
    </p>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

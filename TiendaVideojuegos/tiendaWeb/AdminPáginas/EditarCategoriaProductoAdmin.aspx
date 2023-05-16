<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarCategoriaProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.EditarCategoriaProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <ItemTemplate>
        <div class="content" style="width: 100%; padding-left: 40px; padding-top: 40px;">
            <div class="float-left">
                <asp:Image ID="ProductImage" runat="server" Width="350px" Height="350px" CssClass="img-thumbnail"  />	
            </div>
            <div class="container" style="padding-left: 0px; padding-top: 25px;">
                <p class="card-text font-weight-bold h4"> Nombre del Videojuego: 
                    <p>
                        <asp:TextBox runat="server" ID="nombre" CssClass="form-control form-group"  Width="300px" placeholder=""></asp:TextBox>
                    </p>
                </p>
                </br>
                <p class="font-weight-bold text-dark h5"> Descripción: 
                </p>
                <div class="form-group">
                    <asp:TextBox runat="server" ID="descripcion" class="form-control" Width="500px" Height="150px"  placeholder=""></asp:TextBox>
                </div>
            </div>
        </div>
    </ItemTemplate>

    <div style="padding-left:40px;">
        <asp:Button runat="server" id="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
        <asp:LinkButton runat="server" id="guardar" CssClass="btn btn-warning" OnClientClick="ButtonGuardar" OnClick="ButtonGuardar" Text="Guardar" />
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

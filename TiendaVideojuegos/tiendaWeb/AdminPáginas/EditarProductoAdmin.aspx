<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.EditarProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <ItemTemplate>
        <div class="content" style="width: 100%; padding-left: 40px; padding-top: 40px;">
            <div class="float-left">
                <asp:Image ID="ProductImage" runat="server" Width="350px" Height="350px" CssClass="img-thumbnail" />	
            </div>
            <div class="container" style="padding-left: 0px; padding-top: 25px;">
                <p class="card-text font-weight-bold h4"> Nombre del Videojuego: 
                    <p>
                        <asp:TextBox runat="server" ID="nombre" CssClass="form-control form-group" placeholder="" Width="300px"></asp:TextBox>
                    </p>
                </p>
                <br>
                </br>
                <p class="card-text font-weight-bold h5"> Precio: 
                    <p>
                        <asp:TextBox runat="server" ID="precio" CssClass="form-control form-group" placeholder="" Width="150px"></asp:TextBox>
                    </p>
                </p>
                <br>
                </br>
                <p class="card-text font-weight-bold h5"> Clasificación: 
                    <p>
                        <asp:dropdownlist runat="server" id="clasificacion" CssClass="form-control form-group dropdown-toggle" Width="150px"> 
                            <asp:listitem text="Pegi 3" value="1"></asp:listitem>
                            <asp:listitem text="Pegi 7" value="2" ></asp:listitem>
                            <asp:listitem text="Pegi 12" value="3"></asp:listitem>
                            <asp:listitem text="Pegi 16" value="4"></asp:listitem>
                            <asp:listitem text="Pegi 18" value="5"></asp:listitem>
                        </asp:dropdownlist>
                    </p>
                </p>
                <br>
                </br>
                <p class="font-weight-bold text-dark h5"> Descripción: 
                </p>
                <div class="form-group">
                    <asp:TextBox runat="server" ID="descripcion" class="form-control" Width="500px" Height="150px" placeholder="" ></asp:TextBox>
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

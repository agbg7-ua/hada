<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="tiendaWeb.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Videojuego </p>
    </div>

    <div>
        <asp:ListView ID="ListView1" runat="server" GroupItemCount="1">
             <ItemTemplate>
                        <div class="content" style="width: 100%; padding-left: 40px; padding-top: 40px;">
                                <div class="float-left">
                                    <asp:Image ID="ProductImage" runat="server" Width="350px" Height="350px" CssClass="img-thumbnail"
                                        ImageUrl='<%# Eval("imagen") %>' />	
                                </div>
                                <div class="container" style="padding-left: 0px; padding-top: 25px;">
                                    <p class="font-weight-bold text-dark h1"> 
                                            <%# Eval("nombre") %>
                                    </p>
                                    </br>
                                    <p class="card-text font-weight-bold h4"> Precio: 
                                    </p>
                                    <p class=" card-text h5">
                                        <%# Eval("pvp","{0:c}") %>
                                    </p>
                                    </br>
                                    <p class="card-text font-weight-bold h4"> Fecha de salida: 
                                    </p>
                                    <p class=" card-text h5">
                                        <%# Eval("fecha_salida") %>
                                    </p>
                                    <br>
                                    </br>
                                    <asp:Button CssClass="btn btn-warning" runat="server" ID="carrito" Text="Añadir al carrito" Visible="true" OnClick="button_carrito_OnClientClick" OnClientClick="button_carrito_OnClientClick" />
                                    </br>
                                    </br>
                                    <p class="font-weight-bold text-dark h5"> Descripción: 
                                    </p>
                                    <br>
                                    </br>
                                    <textarea readonly rows="5" class="form-control">
                                        <%# Eval("descripcion") %>
                                    </textarea>
                                </div>
                        </div>
                </ItemTemplate>
            </asp:ListView>
        <div style="width:100%; height: 100px; align-content:center; text-align:center">
            <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Producto.aspx.cs" Inherits="tiendaWeb.Producto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Cabecera de página -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Videojuego </p>
    </div>

    <div>
        <ItemTemplate>
            <div class="content" style="width: 100%; padding-left: 40px; padding-top: 40px;">
                <div class="float-left">
                    <!-- Muestra la imagen del Producto -->
                    <asp:Image ID="ProductImage" runat="server" Width="400px" Height="400px" CssClass="img-thumbnail"/>	
                </div>
                <div class="container" style="padding-left: 60px; padding-top: 25px;">
                    <!-- Muestra el nombre del Producto -->
                    <p class="font-weight-bold text-dark h1"> 
                        <asp:label runat="server" ID="nombre"/>
                    </p>
                    <br>
                    <!-- Muestra el precio del Producto -->
                    <p class=" card-text h3">
                        <asp:label runat="server" ID="precio"/>
                    </p>
                    <br>
                    <!-- Muestra la fecha de salida del Producto -->
                    <p class="card-text font-weight-bold h5"> Fecha de salida: 
                    </p>
                    <p class=" card-text h5">
                        <asp:label runat="server" ID="fecha"/>
                    </p>
                    <br>
                    <!-- TextBox que sirve para elegir la cantidad del Producto a comprar -->
                    <div class="d-flex justify-content-start" style="padding-bottom: 20px;">
                        <p class="card-text font-weight-bold h5" style="padding-right: 20px; padding-top: 7px;"> Cantidad: </p>
                        <asp:TextBox runat="server" ID="cantidad" CssClass="form-control" min="1" max="5" TextMode="Number" style="width: 100px;" onkeydown="return false" placeholder="1"/>
                    </div>
                    <!-- Botones de Añadir al Carrito y Comprar para usuarios ya registrados -->
                    <asp:LinkButton CssClass="btn btn-warning" runat="server" ID="carrito" Text="Añadir al carrito" Visible="true" OnClick="button_carrito_OnClientClick" OnClientClick="button_carrito_OnClientClick"/>
                    <asp:LinkButton CssClass="btn btn-success" runat="server" ID="comprar" Text="Comprar ya" Visible="true" OnClick="button_comprar_OnClientClick" OnClientClick="button_comprar_OnClientClick"/>
                    <!-- Botón de Registrarse para usuarios no registrados -->
                    <asp:LinkButton CssClass="btn btn-danger" runat="server" ID="registrarse" Text="Registrarse/Iniciar Sesión" Visible="true" OnClick="button_registro_OnClientClick" OnClientClick="button_registro_OnClientClick" />
                </div>
                <!-- Muestra la descripción del Producto -->
                <div style="padding-top: 60px; padding-right: 400px; padding-bottom: 20px;">
                    <p class="font-weight-bold text-dark h5"> Descripción: </p>
                    <asp:TextBox runat="server" ID="descripcion" CssClass="form-control" TextMode="MultiLine" ReadOnly="true" Rows="5" />
                </div>
                <!-- HyperLink que lleva a los Comentarios del Producto -->
                <asp:HyperLink runat="server" ID="comentario" >
                    <asp:Label runat="server" ID="vercom" Text="Ver comentarios" />
                </asp:HyperLink>
            </div>
        </ItemTemplate>
        
        <!-- En caso de haber algún error, se mostrará el Label -->
        <div style="width:100%; height: 100px; align-content:center; text-align:center">
            <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
        </div>
    </div>
</asp:Content>

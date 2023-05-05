<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LineaCarrito.aspx.cs" Inherits="tiendaWeb.LineaCarrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   

       <div class="border border-white navbar navbar-expand-lg bg-dark">
  <div class="font-weight-bold h2 text-center mx-auto text-white bg-dark">

     <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-cart4" viewBox="0 0 30 30">
  <path d="M0 2.5A.5.5 0 0 1 .5 2H2a.5.5 0 0 1 .485.379L2.89 4H14.5a.5.5 0 0 1 .485.621l-1.5 6A.5.5 0 0 1 13 11H4a.5.5 0 0 1-.485-.379L1.61 3H.5a.5.5 0 0 1-.5-.5zM3.14 5l.5 2H5V5H3.14zM6 5v2h2V5H6zm3 0v2h2V5H9zm3 0v2h1.36l.5-2H12zm1.11 3H12v2h.61l.5-2zM11 8H9v2h2V8zM8 8H6v2h2V8zM5 8H3.89l.5 2H5V8zm0 5a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0zm9-1a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0z"/>
</svg>
    Linea del Carrito </p>
      </div>
           </div>



    <asp:GridView ID="gridViewLineaCarrito" runat="server" AutoGenerateColumns="False" DataSourceID="sqlDataSourceLineaCarrito">
        <Columns>
            <asp:BoundField DataField="id_carrito" HeaderText="ID Carrito" />
            <asp:BoundField DataField="id_linea" HeaderText="ID Línea" />
            <asp:BoundField DataField="id_producto" HeaderText="ID Producto" />
            <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
            <asp:BoundField DataField="importe" HeaderText="Importe" />
            <asp:BoundField DataField="fecha" HeaderText="Fecha" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="sqlDataSourceLineaCarrito" runat="server" ConnectionString="<%$ ConnectionStrings:miconexion %>" SelectCommand="SELECT [id_carrito], [id_linea], [id_producto], [cantidad], [importe], [fecha] FROM [LineaCarrito]"></asp:SqlDataSource>


             </asp:ListView>
            <br />
            <div style="width:100%; height: 100px; align-content:center; text-align:center">
                <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron carritos." Visible="false" ></asp:Label>
            </div>
</asp:Content>

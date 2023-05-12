<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LineaPedido.aspx.cs" Inherits="tiendaWeb.LineaPedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/pedidoStyle.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Línea de pedido</h2>
    <p>
        <asp:Label ID="Label1" runat="server" class="tab" Text="ID Pedido:"></asp:Label>
        <asp:TextBox ID="IDPedBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Label ID="Label3" runat="server" class="tab" Text="ID Línea:"></asp:Label>
        <asp:TextBox ID="IDLBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Label ID="Label4" runat="server" class="tab" Text="ID Producto:"></asp:Label>
        <asp:TextBox ID="IDProdBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Label ID="Label5" runat="server" class="tab" Text="Cantidad:"></asp:Label>
        <asp:TextBox ID="CantBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Label ID="Label6" runat="server" class="tab" Text="Importe: "></asp:Label>
        <asp:TextBox ID="ImportBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Label ID="resLabel" runat="server"></asp:Label>
    <p>
        <asp:Label ID="Label7" runat="server"></asp:Label>
        <p>
        <asp:Button ID="ButtonCreate" runat="server" Text="Crear" OnClick="ButtonCreate_Click" />
        <asp:Button ID="ButtonUpdate" runat="server" Text="Actualizar" OnClick="ButtonUpdate_Click" />
        <asp:Button ID="ButtonDelete" runat="server" Text="Borrar" OnClick="ButtonDelete_Click" />
        </p>
    </p>
    <p>
        <asp:Button ID="ButtonAllPed" runat="server" Text="Mostrar todas las líneas de un mismo pedido" OnClick="ButtonAllPed_Click" />
        <asp:Button ID="ButtonAllProd" runat="server" Text="Mostrar todas las líneas de un mismo producto" OnClick="ButtonAllProd_Click" />
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Pedido.aspx">Pedido</asp:HyperLink>
    </p>
    <p>
         <asp:ListView runat="server" ID="listaLineasPedido">
  <LayoutTemplate>
    <table cellpadding="1" runat="server" id="tblPedidos" 
        style="width:460px" class ="LV">
      <tr runat="server" id="itemPlaceholder">
      </tr>
    </table>

    <asp:DataPager runat="server" ID="DataPager" PageSize="3">
      <Fields>
        <asp:NumericPagerField
          ButtonCount="3"
          PreviousPageText="<--"
          NextPageText="-->" />
      </Fields>
    </asp:DataPager>
  </LayoutTemplate>
  <ItemTemplate>
     <tr runat="server">
       <td valign="top" colspan="1" align="left" 
           class="ID_Pedido">
           <asp:Label Text="ID Pedido: " runat="server" class="tab" />
         <asp:Label ID="id_pedidoLb" runat="server" 
           Text='<%#Eval("id_pedido") %>' />
       </td>
     </tr>
     <tr runat="server">
       <td valign="top" class="id_Linea">
           <asp:Label ID="LabelId_Linea" runat="server" class="tab" Text="ID Línea: "></asp:Label>
         <asp:Label ID="id_lineaLb" runat="server" 
             Text='<%#Eval("id_linea") %>' />
         <br />
       </td>
    </tr>
    <tr>
       <td valign="top" class="id_producto">
           <asp:Label ID="LabelId_Producto" runat="server" class="tab" Text="ID Producto: "></asp:Label>
         <asp:Label ID="id_productoLb" runat="server" 
             Text='<%#Eval("id_producto") %>' />
         <br />
       </td>
    </tr>
      <tr>
       <td valign="top" class="cantidad">
           <asp:Label ID="LabelCantidad" runat="server" class="tab" Text="Cantidad: "></asp:Label>
         <asp:Label ID="cantidadLb" runat="server" 
             Text='<%#Eval("cantidad") %>' />
         <br />
       </td>
    </tr>
    <tr>
       <td valign="top" class="importe_total">
           <asp:Label ID="Label2" runat="server" class="tab" Text="Importe: "> </asp:Label>
         <asp:Label syle="margin-bottom:72px" ID="LabelImporte" runat="server" 
             Text='<%#Eval("importe") %>'  />
         <br />
           <br />
       </td>
    </tr>
     </tr>
   </ItemTemplate>
</asp:ListView>
    </p>
</asp:Content>

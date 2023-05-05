<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pedido.aspx.cs" Inherits="tiendaWeb.Pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/pedidoStyle.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Pedido</h2>
    <p>
        <asp:Label ID="Label1" runat="server" Text="ID: " class="tab"></asp:Label>
        <asp:TextBox ID="IDBox" runat="server"></asp:TextBox></p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Usuario: " class="tab"></asp:Label>
        <asp:TextBox ID="UserBox" runat="server"></asp:TextBox></p>
    <p><asp:Label ID="Label4" runat="server" Text="Fecha:  " class="tab"></asp:Label>
        <asp:TextBox ID="DateBox" runat="server"></asp:TextBox></p>
    <p><asp:Label ID="Label5" runat="server" Text="Importe Total: " class="tab"></asp:Label>
        <asp:TextBox ID="ITotalBox" runat="server"></asp:TextBox></p>
    <asp:Label ID="resLabel" runat="server"></asp:Label>
    <p><asp:Button ID="ButtonCreate" runat="server" Text="Crear" OnClick="ButtonCreate_Click" class="button"/>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Actualizar" OnClick="ButtonUpdate_Click" class="button"/>
        <asp:Button ID="ButtonDelete" runat="server" Text="Borrar" OnClick="ButtonDelete_Click" class="button"/>
    </p>
    <br />
    <p>
        <asp:Button ID="ButtonAll" runat="server" Text="Mostrar todos los pedidos" OnClick="ButtonAll_Click" class="button"/>
        <asp:Button ID="ButtonAsc" runat="server" Text="Mostrar todos los pedidos por importe (Ascendente)" OnClick="ButtonAsc_Click" class="button"/>
        <asp:Button ID="ButtonDesc" runat="server" Text="Mostrar todos los pedidos por importe (Descendente)" OnClick="ButtonDesc_Click" class="button"/>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LineaPedido.aspx">Línea de Pedido</asp:HyperLink>    
    </p>
    <p>
        <asp:ListView runat="server" ID="ListaPedidos">
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
           class="ID">
           <asp:Label Text="ID: " runat="server" class="tab" />
         <asp:Label ID="idLb" runat="server" 
           Text='<%#Eval("id") %>' />
       </td>
     </tr>
     <tr runat="server">
       <td valign="top" class="id_Usuario">
           <asp:Label ID="LabelId_Usuario" runat="server" class="tab" Text="Usuario: "></asp:Label>
         <asp:Label ID="id_usuarioLb" runat="server" 
             Text='<%#Eval("id_usuario") %>' />
         <br />
       </td>
    </tr>
    <tr>
       <td valign="top" class="fecha">
           <asp:Label ID="LabelFecha" runat="server" class="tab" Text="Fecha: "></asp:Label>
         <asp:Label ID="fechaLb" runat="server" 
             Text='<%#Eval("fecha") %>' />
         <br />
       </td>
    </tr>
    <tr>
       <td valign="top" class="importe_total">
           <asp:Label ID="Label2" runat="server" class="tab" Text="Importe_total: "> </asp:Label>
         <asp:Label syle="margin-bottom:72px" ID="LabelImporte" runat="server" 
             Text='<%#Eval("importe_total") %>'  />
         <br />
           <br />
       </td>
    </tr>
     </tr>
   </ItemTemplate>
</asp:ListView>
    </p>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="tiendaWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<<<<<<< HEAD
    
     <!-- Title -->
    <div class="border border-white navbar navbar-expand-lg bg-dark">
  <div class="font-weight-bold h2 text-center mx-auto text-white bg-dark">

     <svg xmlns="http://www.w3.org/2000/svg" width="30" height="30" fill="currentColor" class="bi bi-cart4" viewBox="0 0 30 30">
  <path d="M0 2.5A.5.5 0 0 1 .5 2H2a.5.5 0 0 1 .485.379L2.89 4H14.5a.5.5 0 0 1 .485.621l-1.5 6A.5.5 0 0 1 13 11H4a.5.5 0 0 1-.485-.379L1.61 3H.5a.5.5 0 0 1-.5-.5zM3.14 5l.5 2H5V5H3.14zM6 5v2h2V5H6zm3 0v2h2V5H9zm3 0v2h1.36l.5-2H12zm1.11 3H12v2h.61l.5-2zM11 8H9v2h2V8zM8 8H6v2h2V8zM5 8H3.89l.5 2H5V8zm0 5a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0zm9-1a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm-2 1a2 2 0 1 1 4 0 2 2 0 0 1-4 0z"/>
</svg>
    Carrito </p>
      </div>

  
        </div>


     <div class= "col-auto text-center mx-auto">

            <asp:ListView runat="server" ID="listView" GroupItemCount="6">

                <GroupTemplate>
                    <tr>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                    </tr>
                </GroupTemplate>

                <GroupSeparatorTemplate>
                    <tr id="Tr1" runat="server" visible="false">
                        <td colspan="3" style="padding: 5px 5px 5px 5px;"><hr /></td>
                    </tr>
                </GroupSeparatorTemplate>

                <LayoutTemplate>
                    <table>
                        <asp:PlaceHolder ID="groupPlaceHolder" runat="server" />
                    </table>
                </LayoutTemplate>

                <ItemTemplate>
                
                </ItemTemplate>
            </asp:ListView>
            <br />
            <div style="width:100%; height: 100px; align-content:center; text-align:center">
                <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron carritos, inicia tus compras primero." Visible="false" ></asp:Label>
            </div>
        
</asp:Content>

=======

    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Carrito </p>
    </div>

    <div class="form-control" style="padding-top: 20px; padding-left: 50px; padding-right: 50px;">
        <asp:GridView CssClass="table table-hover" ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="2" CellSpacing="2" > 
             <Columns>
                <asp:TemplateField HeaderText="Línea de Carrito"> 
                    <ItemTemplate> 
                        <%# Eval("id_linea") %> 
                    </ItemTemplate> 
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Producto"> 
                    <ItemTemplate> 
                        <%# Eval("id_producto") %>
                    </ItemTemplate> 
                </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Cantidad"> 
                    <ItemTemplate> 
                        <%# Eval("cantidad") %>  
                    </ItemTemplate> 
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Importe"> 
                    <ItemTemplate> 
                        <%# Eval("importe", "{0:c}") %>  
                    </ItemTemplate> 
                </asp:TemplateField> 
                <asp:TemplateField HeaderText="Eliminar"> 
                    <ItemTemplate> 
                        <asp:Button CssClass="btn btn-danger" runat="server" ID="Button3" Text="Eliminar" Visible="true" OnClick="button_eliminar_OnClientClick" OnClientClick="button_eliminar_OnClientClick" />
                    </ItemTemplate> 
                </asp:TemplateField> 
            </Columns> 
        </asp:GridView>
    </div>

</asp:Content>
>>>>>>> develop

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="tiendaWeb.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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

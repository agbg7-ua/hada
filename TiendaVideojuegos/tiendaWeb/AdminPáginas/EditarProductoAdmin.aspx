<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditarProductoAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.EditarProductoAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ListView ID="listView" runat="server" GroupItemCount="1" OnItemDataBound="Clasificacion">
        <ItemTemplate>
            <div class="content" style="width: 100%; padding-left: 40px; padding-top: 40px;">
                <div class="float-left">
                    <asp:Image ID="ProductImage" runat="server" Width="350px" Height="350px" CssClass="img-thumbnail" ImageUrl='<%# Eval("imagen") %>' />	
                </div>
                <div class="container" style="padding-left: 0px; padding-top: 25px;">
                    <p class="card-text font-weight-bold h4"> Nombre del Videojuego: 
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="nombre" CssClass="form-control" placeholder='<%# Eval("nombre") %>' Width="300px"></asp:TextBox>
                        </div>
                    </p>
                    </br>
                    <p class="card-text font-weight-bold h5"> Precio: 
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="precio" CssClass="form-control" placeholder='<%# Eval("pvp") %>' Width="150px"></asp:TextBox>
                        </div>
                    </p>
                    </br>
                    <p class="card-text font-weight-bold h5"> Fecha de salida: 
                        <div class="form-group">
                            <asp:TextBox runat="server" ID="fecha" CssClass="form-control" placeholder='<%# Eval("fecha_salida") %>' Width="300px"></asp:TextBox>
                        </div>
                    </p>
                    </br>
                    <p class="card-text font-weight-bold h5"> Clasificación: 
                        <div class="form-group">
                            <asp:dropdownlist runat="server" id="clasificacion" CssClass="form-control dropdown-toggle" OnSelectedIndexChanged="clasificacion_SelectedIndexChanged" Width="150px"> 
                                <asp:listitem text="Pegi 3" value="1"></asp:listitem>
                                <asp:listitem text="Pegi 7" value="2"></asp:listitem>
                                <asp:listitem text="Pegi 12" value="3"></asp:listitem>
                                <asp:listitem text="Pegi 16" value="4"></asp:listitem>
                                <asp:listitem text="Pegi 18" value="5"></asp:listitem>
                            </asp:dropdownlist>
                        </div>
                    </p>
                    </br>
                    <p class="font-weight-bold text-dark h5"> Descripción: 
                    </p>
                    <div class="form-group">
                        <textarea ID="descripcion" class="form-control" placeholder='<%# Eval("descripcion") %>' rows="4" cols="100"></textarea>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>

    <div style="padding-left:40px;">
        <asp:Button runat="server" id="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
        <asp:LinkButton runat="server" id="guardar" CssClass="btn btn-warning" OnClientClick="ButtonGuardar" OnClick="ButtonGuardar" Text="Guardar" />
    </div>

    <div style="width:100%; height: 100px; align-content:center; text-align:center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron productos, intentelo más tarde." Visible="false" ></asp:Label>
    </div>

</asp:Content>

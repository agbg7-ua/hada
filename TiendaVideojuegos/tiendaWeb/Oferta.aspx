<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Oferta.aspx.cs" Inherits="tiendaWeb.Oferta1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Ofertas del mes </p>
    </div>

    <div class="container-fluid" style="min-height: 100vh">
        <div class="row w-100" style="padding-left: 200px;">
            <div class="col col-md-4">
                <ItemTemplate>
                    <div style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                        <div class="card border border-dark" style="height: 450px;">
                            <asp:Image ID="Image1" CssClass="" runat="server" Width="268px" Height="268px"
                                        ImageUrl="" />	
                            <div class="card-body text-center">
                                <asp:Label runat="server" id="nombre1" CssClass="card-title text-dark h5" />
                                <br />
                                <asp:Label runat="server" id="precioant1" CssClass="card-title text-dark h5 text-decoration-line-through" />
                                <br />
                                <asp:Label runat="server" id="oferta1" CssClass="card-title h5 text-danger" />
                                <div style="padding-top: 20px;">
                                    <asp:Button runat="server" ID="comprar1" CssClass="btn btn-warning" OnClientClick="ButtonComprar1" OnClick="ButtonComprar1" Text="COMPRA YA" />
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </div>

             <div class="col col-md-4">
                <ItemTemplate>
                    <div style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                        <div class="card border border-dark" style="height: 450px;">
                            <asp:Image ID="Image2" CssClass="" runat="server" Width="268px" Height="268px"
                                        ImageUrl="" />	
                            <div class="card-body text-center">
                                <asp:Label runat="server" id="nombre2" CssClass="card-title text-dark h5" />
                                <br />
                                <asp:Label runat="server" id="precioant2" CssClass="card-title text-dark h5 text-decoration-line-through" />
                                <br />
                                <asp:Label runat="server" id="oferta2" CssClass="card-title h5 text-danger" />
                                <br/>
                                    <asp:Button runat="server" ID="comprar2" CssClass="btn btn-warning" OnClientClick="ButtonComprar2" OnClick="ButtonComprar2" Text="COMPRA YA"/>
                                
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </div>

             <div class="col col-md-4">
                <ItemTemplate>
                    <div style="width:300px; height:350px; padding: 5px 5px 5px 25px; padding-top: 20px;">
                        <div class="card border border-dark" style="height: 450px;">
                            <asp:Image ID="Image3" CssClass="" runat="server" Width="268px" Height="268px"
                                        ImageUrl="" />	
                            <div class="card-body text-center">
                                <asp:Label runat="server" id="nombre3" CssClass="card-title text-dark h5" />
                                <br />
                                <asp:Label runat="server" id="precioant3" CssClass="card-title text-dark h5 text-decoration-line-through" />
                                <br />
                                <asp:Label runat="server" id="oferta3" CssClass="card-title h5 text-danger" />
                                <div style="padding-top: 20px;">
                                    <asp:Button runat="server" ID="comprar3" CssClass="btn btn-warning" OnClientClick="ButtonComprar3" OnClick="ButtonComprar3" Text="COMPRA YA"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </div>
        </div>
    </div>


</asp:Content>

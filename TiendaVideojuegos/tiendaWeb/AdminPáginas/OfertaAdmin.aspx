<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="OfertaAdmin.aspx.cs" Inherits="tiendaWeb.AdminPáginas.OfertaAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="margin:50px">
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow Width="400">
                <asp:TableCell>

                    <div class=" align-content-center border border-secondary" style="height: 300px">
                        <div style="margin: 10px">
                            <asp:Label ID="Label3" runat="server" Text="Oferta 1" style="margin-left: 50px" Font-Bold="true" ></asp:Label>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="Juego: "></asp:Label>
                            <%--<asp:TextBox ID="TextBox_juego_1" runat="server" CssClass="input-group-text"></asp:TextBox>--%>
                            <asp:DropDownList ID="DropDownList_juego_1" runat="server"></asp:DropDownList>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="DropDownList_juego_1" ValidationGroup="1" ForeColor="red" Font-Bold="true"></asp:RequiredFieldValidator>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Descuento: "></asp:Label>
                            <asp:TextBox ID="TextBox_precio_1" runat="server" TextMode="Number" CssClass="input-group-text"></asp:TextBox>
                            <br />
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Descuento fuera del rango permitido" ControlToValidate="TextBox_precio_1" MaximumValue="9999" MinimumValue="0" ForeColor="red" Font-Bold="true" ValidationGroup="1"></asp:RangeValidator>
                            <br />
                            <div style="margin-left: 50px">
                                <asp:Button ID="Guardar_1" runat="server" Text="Guardar" CssClass="btn" />
                            </div>
                        </div>
                    </div>


                </asp:TableCell>
                <asp:TableCell>
                <div class=" align-content-center border border-secondary">
                    <div style="margin:10px">
                        asd
                    </div>
                </div>
                </asp:TableCell>
                <asp:TableCell>
                <div class=" align-content-center border border-secondary">
                    <div style="margin:10px">
                        asd
                    </div>
                </div>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    <div style="padding-left: 40px;">
        <asp:Button runat="server" ID="volver" CssClass="btn btn-secondary" OnClientClick="ButtonVolver" OnClick="ButtonVolver" Text="Volver" />
    </div>
    <div style="width: 100%; height: 100px; align-content: center; text-align: center">
        <asp:Label CssClass="labelVacio" runat="server" ID="Label_info" Text="" Visible="true" Font-Bold="true"></asp:Label>
    </div>
    <div style="width: 100%; height: 100px; align-content: center; text-align: center">
        <asp:Label CssClass="labelVacio" runat="server" ID="textboxVacio" Text="No se encontraron desarrolladores, intentelo más tarde." Visible="false"></asp:Label>
    </div>
</asp:Content>

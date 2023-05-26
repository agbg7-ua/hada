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
                            <asp:DropDownList ID="DropDownList_juego_1" runat="server" ValidationGroup="1"></asp:DropDownList>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Elige un juego para la oferta" ControlToValidate="DropDownList_juego_1" ValidationGroup="1" ForeColor="red" Font-Bold="true"></asp:RequiredFieldValidator>
                            <br />
                            <asp:Label ID="Label2" runat="server" Text="Descuento: "></asp:Label>
                            <asp:TextBox ID="TextBox_precio_1" runat="server" TextMode="number" CssClass="input-group-text" Width="100px" ValidationGroup="1"></asp:TextBox>
                            <br />
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Descuento fuera del rango permitido, 0-100%" ControlToValidate="TextBox_precio_1" MaximumValue="100" MinimumValue="0" Type="Integer" ForeColor="red" Font-Bold="true" ValidationGroup="1"></asp:RangeValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Escribe un precio para la oferta" ValidationGroup="1" Font-Bold="true" ForeColor="red" ControlToValidate="TextBox_precio_1"></asp:RequiredFieldValidator>
                            <br />
                            <div style="margin-left: 50px">
                                <asp:Button ID="Guardar_1" runat="server" Text="Guardar" CssClass="btn" ValidationGroup="1" OnClick="Guardar_1_Click" />
                                <asp:Button ID="Borrar_1" runat="server" Text="Borrar"  CssClass="btn" OnClick="Borrar_1_Click" />
                            </div>

                        </div>
                    </div>


                </asp:TableCell>
                <asp:TableCell>
                <div class=" align-content-center border border-secondary" style="height: 300px">
                    <div style="margin:10px">
                            <asp:Label ID="Label4" runat="server" Text="Oferta 2" style="margin-left: 50px" Font-Bold="true" ></asp:Label>
                            <br />
                            <asp:Label ID="Label5" runat="server" Text="Juego: "></asp:Label>
                            <%--<asp:TextBox ID="TextBox_juego_1" runat="server" CssClass="input-group-text"></asp:TextBox>--%>
                            <asp:DropDownList ID="DropDownList_juego_2" runat="server" ValidationGroup="2"></asp:DropDownList>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Elige un juego para la oferta" ControlToValidate="DropDownList_juego_2" ValidationGroup="2" ForeColor="red" Font-Bold="true"></asp:RequiredFieldValidator>
                            <br />
                            <asp:Label ID="Label6" runat="server" Text="Descuento: "></asp:Label>
                            <asp:TextBox ID="TextBox_precio_2" runat="server" TextMode="number" CssClass="input-group-text" Width="100px" ValidationGroup="2"></asp:TextBox>
                            <br />
                            <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Descuento fuera del rango permitido, 0-100%" ControlToValidate="TextBox_precio_2" MaximumValue="100" MinimumValue="0" Type="Integer" ForeColor="red" Font-Bold="true" ValidationGroup="2"></asp:RangeValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Escribe un precio para la oferta" ValidationGroup="2" Font-Bold="true" ForeColor="red" ControlToValidate="TextBox_precio_2"></asp:RequiredFieldValidator>
                            <br />
                            <div style="margin-left: 50px">
                                <asp:Button ID="Guardar_2" runat="server" Text="Guardar" CssClass="btn" ValidationGroup="2" OnClick="Guardar_2_Click" />
                                <asp:Button ID="Borrar_2" runat="server" Text="Borrar"  CssClass="btn" OnClick="Borrar_2_Click"  />
                            </div>

                    </div>
                </div>
                </asp:TableCell>
                <asp:TableCell>
                <div class=" align-content-center border border-secondary" style="height: 300px">
                    <div style="margin:10px">
                            <asp:Label ID="Label7" runat="server" Text="Oferta 3" style="margin-left: 50px" Font-Bold="true" ></asp:Label>
                            <br />
                            <asp:Label ID="Label8" runat="server" Text="Juego: "></asp:Label>
                            <%--<asp:TextBox ID="TextBox_juego_1" runat="server" CssClass="input-group-text"></asp:TextBox>--%>
                            <asp:DropDownList ID="DropDownList_juego_3" runat="server" ValidationGroup="3"></asp:DropDownList>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Elige un juego para la oferta" ControlToValidate="DropDownList_juego_3" ValidationGroup="3" ForeColor="red" Font-Bold="true"></asp:RequiredFieldValidator>
                            <br />
                            <asp:Label ID="Label9" runat="server" Text="Descuento: "></asp:Label>
                            <asp:TextBox ID="TextBox_precio_3" runat="server" TextMode="number" CssClass="input-group-text" Width="100px" ValidationGroup="3"></asp:TextBox>
                            <br />
                            <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="Descuento fuera del rango permitido, 0-100%" ControlToValidate="TextBox_precio_3" MaximumValue="100" MinimumValue="0" Type="Integer" ForeColor="red" Font-Bold="true" ValidationGroup="3"></asp:RangeValidator>
                            <br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Escribe un precio para la oferta" ValidationGroup="3" Font-Bold="true" ForeColor="red" ControlToValidate="TextBox_precio_3"></asp:RequiredFieldValidator>
                            <br />
                            <div style="margin-left: 50px">
                                <asp:Button ID="Guardar_3" runat="server" Text="Guardar" CssClass="btn" ValidationGroup="3" OnClick="Guardar_3_Click"/>
                                <asp:Button ID="Borrar_3" runat="server" Text="Borrar"  CssClass="btn" OnClick="Borrar_3_Click" />
                            </div>
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

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Desarrrolador.aspx.cs" Inherits="tiendaWeb.Desarrrolador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/bootstrap.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">
        <div class="row">
            <div class="col-md-12">
                <h2>Desarrolladora</h2>
            </div>
        </div>
    <asp:Label ID="Label1" runat="server" Text="Nombre: " Font-Bold="true"></asp:Label>
    <asp:Label ID="Label_nombre" runat="server" Text="Label_nombre"></asp:Label>
    <asp:TextBox ID="TextBox_nombre" runat="server" OnTextChanged="TextBox1_TextChanged" CssClass="form-control input-lg"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_nombre" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
    <br />



    <asp:Label ID="Label2" runat="server" Text="Descripcion: " Font-Bold="true"></asp:Label>
    <br />
    <asp:Label ID="Label_descripcion" runat="server" Text="asdasd" Width="800px" ></asp:Label>

    <asp:TextBox ID="TextBox_descripcion" runat="server" OnTextChanged="TextBox_descripcion_TextChanged" TextMode="MultiLine" Height="172px" Width="716px" CssClass="form-control input-lg"></asp:TextBox>
    <br />


    <asp:Label ID="Label3" runat="server" Text="Origen: " Font-Bold="true"></asp:Label>
    <asp:Label ID="Label_origen" runat="server" Text="Label_oringen"></asp:Label>
    <asp:TextBox ID="TextBox_origen" runat="server" CssClass="form-control input-lg"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_origen" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Fecha de creacion: " Font-Bold="true"></asp:Label>
    <asp:Label ID="Label_fecha" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox_fecha" runat="server" CssClass="form-control input-lg"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_fecha" ValidationExpression="^.*$"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Website: "  Font-Bold="true"></asp:Label>
    <asp:Label ID="Label_web" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox_web" runat="server" CssClass="form-control input-lg"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_web" ValidationExpression="^.*$"></asp:RegularExpressionValidator>

    <br />
    <br />

    <asp:Button ID="Button_editar" runat="server" Text="Editar" OnClick="Button_editar_Click" CssClass="btn"/>
    <asp:Button ID="Button_eliminar" runat="server" Text="Eliminar" class=".btn"/>
    <asp:Button ID="Button_nuevo" runat="server" Text="Nuevo" class=".btn" />


        <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Titulos: "></asp:Label>

    <asp:Image ID="Image1" runat="server" ImageUrl="Imagenes/gustav.png" />

        </div>
    </asp:Content>

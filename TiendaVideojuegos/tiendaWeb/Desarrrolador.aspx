<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Desarrrolador.aspx.cs" Inherits="tiendaWeb.Desarrrolador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
    <asp:Label ID="Label4" runat="server" Text="Label_nombre"></asp:Label>
    <asp:TextBox ID="TextBox_nombre" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_nombre"></asp:RegularExpressionValidator>
    <br />



    <asp:Label ID="Label2" runat="server" Text="Descripcion"></asp:Label>
    <br />
    <asp:Label ID="Label_descripcion" runat="server" Text="asdasd"></asp:Label>
    <asp:TextBox ID="TextBox_descripcion" runat="server" OnTextChanged="TextBox_descripcion_TextChanged"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_descripcion"></asp:RegularExpressionValidator>
    <br />


    <asp:Label ID="Label3" runat="server" Text="Origen"></asp:Label>
    <asp:Label ID="Label_origen" runat="server" Text="Label_oringen"></asp:Label>
    <asp:TextBox ID="TextBox_origen" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_origen"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Fecha_creacion: "></asp:Label>
    <asp:Label ID="Label_fecha" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox_fecha" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_fecha"></asp:RegularExpressionValidator>
    <br />
    <asp:Label ID="Label9" runat="server" Text="Web"></asp:Label>
    <asp:Label ID="Label_web" runat="server" Text="Label"></asp:Label>
    <asp:TextBox ID="TextBox_web" runat="server"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="TextBox_web"></asp:RegularExpressionValidator>

    <br />
    <br />
    <asp:Button ID="Button_editar" runat="server" Text="Editar" OnClick="Button_editar_Click" />
    </asp:Content>

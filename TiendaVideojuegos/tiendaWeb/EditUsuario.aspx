<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EditUsuario.aspx.cs" Inherits="tiendaWeb.EditUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Edita tu Perfil </p>
    </div>

     <div class="col">
     <div class="container" style="width: 50%; float:left; height:750px;text-align:center;justify-content:center;border-right:3px solid black;border-bottom:3px solid black;border-top:3px solid black">
        <asp:Image ID="Image1" runat="server" ImageUrl="Imagenes/profile.jpg"  alt="Avatar" class="avatar" style="margin:3px"/><br>
        <br>
        <div style="position:absolute; margin:0; padding-left: 180px;">
            <label class="card-text font-weight-bold h4"> Username: </label>
            <asp:TextBox runat="server" ID="username" TextMode="SingleLine" CssClass="form-control" ReadOnly="true" Width="500px"></asp:TextBox>
             <br>
            <label class="card-text font-weight-bold h4"> Email: </label>
            <asp:TextBox runat="server" ID="email" TextMode="SingleLine" CssClass="form-control" ReadOnly="true" Width="500px"></asp:TextBox>
        </div>
     </div>
     <div class="container" style="width: 50%; float:right; height:750px;border-bottom:3px solid black;border-top:3px solid black">
        <h3 style="text-align: center;">Información</h3><br />
            <asp:Panel runat="server" ID="signupvalidation" DefaultButton="registbutton">
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Nombre: </label>
                    <asp:TextBox runat="server" ID="nombre" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="nombre" ErrorMessage="Nombre no debe superar los 30 caracteres" ValidationExpression="[a-zA-Z]{1,30}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Apellidos: </label>
                    <asp:TextBox runat="server" ID="apellidos" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="apellidos" ErrorMessage="Apellidos no debe superar los 30 caracteres" ValidationExpression="[a-zA-Z' ']{1,30}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Edad: </label>
                    <asp:TextBox runat="server" ID="edad" TextMode="Number" CssClass="form-control" ValidationGroup="signup" min="16" max="110"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="edad" ErrorMessage="Edad debe ser un número entero" ValidationExpression="[0-9]{1,3}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Teléfono: </label>
                    <asp:TextBox runat="server" ID="telefono" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="telefono" ErrorMessage="Teléfono no cumple con los requisitos" ValidationExpression="[0-9]{1,12}$" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Calle: </label>
                    <asp:TextBox runat="server" ID="calle" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="calle" ErrorMessage="Calle no cumple con los requisitos" ValidationExpression="[a-zA-Z0-9' ']{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Pueblo: </label>
                    <asp:TextBox runat="server" ID="pueblo" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="pueblo" ErrorMessage="Pueblo no cumple con los requisitos" ValidationExpression="[a-zA-Z' ']{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Provincia: </label>
                    <asp:TextBox runat="server" ID="provincia" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="provincia" ErrorMessage="Provincia no cumple con los requisitos" ValidationExpression="[a-zA-Z' ']{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <div class="d-flex justify-content-center">
                    <label class="card-text font-weight-bold h6" style="padding-right: 20px; padding-top: 10px;"> Código Postal: </label>
                    <asp:TextBox runat="server" ID="codpostal" TextMode="SingleLine" CssClass="form-control" ValidationGroup="signup"></asp:TextBox>
                    <div class="invalid-feedback">
                        <asp:RegularExpressionValidator runat="server" ControlToValidate="codpostal" ErrorMessage="Código postal no cumple con los requisitos" ValidationExpression="[0-9]{1,45}" ValidationGroup="signup"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <br>
                <asp:Button class="regbutton" ID="registbutton" runat="server" Text="Finalizar" OnClick="Button1_Click" />
                <div class="container-fluid align-content-center" style="width: 500px; padding-top: 20px; padding-right: 20px; padding-left: 20px; padding-bottom: 20px;">
                    <div class="alert alert-danger" role="alert" id="Div1" runat="server" >
                        <p class="message">
                            <asp:Label ID="Msg2" runat="server" ></asp:Label>
                            <asp:ValidationSummary ID="signupvalidations" runat="server" DisplayMode="BulletList" font-size="Small" ValidationGroup="signup"/>
                        </p>
                    </div>
                </div>
            </asp:Panel>
        </div>
    </div>
     <style>
       body {
           background-size:100%;
            background-color:white;
}
           .avatar {
  width: 60%;
  height: 400px;
  border-radius: 50%;
}
    .col{
    display: flex; 
    width: 100%;
    }
    .container {
        flex:1;
        padding: 16px;
    }
    hr {
    border: 1px solid black;
    margin-bottom:25px;
}
    a {
  color: dodgerblue;
    }
    .regbutton{
      background-color: grey;
      color: white;
      padding: 16px 20px;
      border: none;
      cursor: pointer;
      width: 90%;
      opacity: 0.9;
    }
</style>
</asp:Content>

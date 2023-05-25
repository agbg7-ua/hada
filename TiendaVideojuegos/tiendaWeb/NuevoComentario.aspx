<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NuevoComentario.aspx.cs" Inherits="tiendaWeb.NuevoComentario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Nuevo Comentario </p>
    </div>
    <div class ="container">
        <h5 style="margin-top:10px"> Valoración</h5>
        <div style="margin:10px">
            <div class="rating">
<label>
    <asp:RadioButton ID="star5" runat="server" GroupName="test" Text="5" CssClass="star" OnCheckedChanged="RatingChanged" AutoPostBack="true" />
    <img src="Imagenes/empty-star.png" alt="Empty Star" class="star-image" />
</label>

<label>
    <asp:RadioButton ID="star4" runat="server" GroupName="test" Text="4" CssClass="star" OnCheckedChanged="RatingChanged" AutoPostBack="true" />
    <img src="Imagenes/empty-star.png" alt="Empty Star" class="star-image" />
</label><label>
    <asp:RadioButton ID="star3" runat="server" GroupName="test" Text="3" CssClass="star" OnCheckedChanged="RatingChanged" AutoPostBack="true" />
    <img src="Imagenes/empty-star.png" alt="Empty Star" class="star-image" />
</label>

<label>
    <asp:RadioButton ID="star2" runat="server" GroupName="test" Text="2" CssClass="star" OnCheckedChanged="RatingChanged" AutoPostBack="true" />
    <img src="Imagenes/empty-star.png" alt="Empty Star" class="star-image" />
</label>
                
<label>
    <asp:RadioButton ID="star1" runat="server" GroupName="test" Text="1" CssClass="star" OnCheckedChanged="RatingChanged" AutoPostBack="true" />
    <img src="Imagenes/empty-star.png" alt="Empty Star" class="star-image" />
</label>
            </div>
        </div>

    </div>
    <div class="container">

        <form action="upload.php" method="post" style="background-color:lightgray">
                    <h5 style =" margin-top:10px">Añade imagenes</h5>
            <input type="file" name="file" id="file" style="margin:10px;"/>
        </form>
    </div>
    <div class="container">
        <h5 style="margin-top:10px">Añade una valoración escrita</h5>
        <asp:TextBox ID="TextBox1" runat="server" placeholder =" Añada su valoración detallada del producto" TextMode="multiline" style="width:80%; margin: 10px; background-color:lightgray"> </asp:TextBox>
        <asp:Label ID="outputMsg" runat="server" Text="Label"><br /></asp:Label><br />
    </div>
    <div class="button" style = "margin-top: 10px;width:20%;float:right">
        <asp:Button class="regbutton" ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
    </div>

    <style>
        body{
            align-content:center;
           

        }
        .he{
            text-align:center;
        }
        .fa {
  font-size: 25px;
}
        .rating {
    display: inline-block;
}

.star-image {
  height: 50px;
  width: 50px;
  cursor: pointer;
}

.star-image.full {
  content: url(Imagenes/full-star.png); /* Replace with the path to your full star image */
}
    </style>
</asp:Content>


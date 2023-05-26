<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Comentario.aspx.cs" Inherits="tiendaWeb.Oferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
        <div class="border border-white navbar navbar-expand-lg bg-dark">
        <p class="font-weight-bold h2 text-center mx-auto text-white bg-dark"> Comentarios </p>
    </div>
<div class="game" style=" height:400px; border: 3px solid black;">
    <div class="image" style="width: 30%; float:left; height:388px;">
    <asp:Image ID="myImage" runat="server" ImageUrl=" " Width=100% Height=100%/>
        </div>
    <div class="desc" style="width: 68%; float:right; height:288px; font-size:x-large">
        <br/>

        <asp:Label ID="nameText" runat="server" style="margin:5px; font-size:20px; font-weight:bold"></asp:Label><br />
    <asp:Label ID="descText" runat="server" style="margin:5px"></asp:Label>
            <div class="button" style = "margin-top: 20px">
        <asp:Button class="regbutton" style="background-color:grey;color:white" ID="Button1" runat="server" OnClick="comentButton" Text="Añadir un comentario"  />
    </div>
    </div>

</div><br />
        <h6>Filtrar por valoraciones</h6>
        <div class="dropdown">
            <asp:dropdownlist runat="server" id="ddlTest"  OnSelectedIndexChanged="ddlTest_SelectedIndexChanged" AutoPostBack="true"> 
                 <asp:listitem text="Valoraciones con 5 estrellas" value="5" Selected="True"></asp:listitem>
                 <asp:listitem text="Valoraciones con 4 estrellas" value="2"></asp:listitem>
                 <asp:listitem text="Valoraciones con 3 estrellas" value="3"></asp:listitem>
                 <asp:listitem text="Valoraciones con 2 estrellas" value="2"></asp:listitem>
                <asp:listitem text="Valoraciones con 1 estrella" value="1"></asp:listitem>
            </asp:dropdownlist>
        </div>

         <asp:GridView ID="gridView" runat="server" AutoGenerateColumns="False" 
    CssClass="comment-grid">
    <Columns>
        <asp:BoundField DataField="CommenterName" HeaderText="Name" />
        <asp:BoundField DataField="CommentText" HeaderText="Comment" />
        <asp:BoundField DataField="Timestamp" HeaderText="Timestamp" />
    </Columns>
</asp:GridView>
         <asp:Label ID="outputMsg" runat="server" Text="Label"><br /></asp:Label><br />
   

<style>
    * {
  box-sizing: border-box;
}

    .avatar {
  vertical-align: middle;
  width: 50px;
  height: 50px;
  border-radius: 50%;
}

.father{
      font-family: Arial;
  margin: 0 auto; /* Center website */
  max-width: 800px; /* Max width */
  padding: 20px;
}
.galeria {
  height: 300px;
  width: 280px;
  border: 1px solid #555;
  position: relative;  
}
.galeria img {
    position:absolute ;
    top: 0;
    left: 0;
    opacity: 0;
    transition: opacity 3s;
  }
.galeria input[type=radio] {
  position: relative;
  bottom: calc(-300px - 1.5em);
  left: .5em;
}

.galeria input[type=radio]:nth-of-type(1):checked ~ img:nth-of-type(1) {
  opacity: 1;
}

.galeria input[type=radio]:nth-of-type(2):checked ~ img:nth-of-type(2) {
  opacity: 1;
}

.galeria input[type=radio]:nth-of-type(3):checked ~ img:nth-of-type(3) {
  opacity: 1;
}

.galeria input[type=radio]:nth-of-type(4):checked ~ img:nth-of-type(4) {
  opacity: 1;
}
.heading {
  font-size: 25px;
  margin-right: 25px;
}

.fa {
  font-size: 25px;
}

.checked {
  color: orange;
}

/* Three column layout */
.side {
  float: left;
  width: 15%;
  margin-top: 10px;
}

.middle {
  float: left;
  width: 70%;
  margin-top: 10px;
}

/* Place text to the right */
.right {
  text-align: right;
}

/* Clear floats after the columns */
.row:after {
  content: "";
  display: table;
  clear: both;
}

/* The bar container */
.bar-container {
  width: 100%;
  background-color: #f1f1f1;
  text-align: center;
  color: white;
}

/* Individual bars */
.bar-5 {width: 60%; height: 18px; background-color: #04AA6D;}
.bar-4 {width: 30%; height: 18px; background-color: #2196F3;}
.bar-3 {width: 10%; height: 18px; background-color: #00bcd4;}
.bar-2 {width: 4%; height: 18px; background-color: #ff9800;}
.bar-1 {width: 15%; height: 18px; background-color: #f44336;}

/* Responsive layout - make the columns stack on top of each other instead of next to each other */
@media (max-width: 400px) {
  .side, .middle {
    width: 100%;
  }
  /* Hide the right column on small screens */
  .right {
    display: none;
  }
}
</style>
</asp:Content>

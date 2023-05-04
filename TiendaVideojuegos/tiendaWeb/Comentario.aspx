<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Comentario.aspx.cs" Inherits="tiendaWeb.Oferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <h1 style="background-color:mediumpurple;color: white "> Comentarios</h1>
<div class="game" style="width: 55%; float:left; height:295px; border: 3px solid grey;">
    <div class="image" style="width: 44%; float:left; height:288px;">
    <asp:Image ID="myImage" runat="server" ImageUrl="https://m.media-amazon.com/images/I/81xB6YDs8rL._AC_SX385_.jpg" Width=100% Height=100%/>
        </div>
    <div class="desc" style="width: 55%; float:right; height:288px">
        <br/>
    <h3> NBA 2K23</h3><br/>
    <p style="margin:5px">NBA 2K23 es un videojuego de baloncesto de 2022 desarrollado por Visual Concepts y publicado por 2K, basado en la Asociación Nacional de Baloncesto. Es la entrega número 24 de la franquicia NBA 2K y es el sucesor de NBA 2K22.</p>
    </div>
</div>
<div class ="father" style="width: 45%; float:right; height:295px;border-bottom: 3px solid grey; border-top: 3px solid grey">
    <span class="heading">Puntuación de los usuarios</span>
    <span class="fa fa-star checked"></span>
    <span class="fa fa-star checked"></span>
    <span class="fa fa-star checked"></span>
    <span class="fa fa-star checked"></span>
    <span class="fa fa-star"></span>
    <p>4.1 de media basado en 251 reseñas.</p>
    <hr style="border:3px solid #f1f1f1">


    <div class="row">
      <div class="side">
        <div>5 star</div>
      </div>
      <div class="middle">
        <div class="bar-container">
          <div class="bar-5"></div>
        </div>
      </div>
      <div class="side right">
        <div>150</div>
      </div>
      <div class="side">
        <div>4 star</div>
      </div>
      <div class="middle">
        <div class="bar-container">
          <div class="bar-4"></div>
        </div>
      </div>
      <div class="side right">
        <div>63</div>
      </div>
      <div class="side">
        <div>3 star</div>
      </div>
      <div class="middle">
        <div class="bar-container">
          <div class="bar-3"></div>
        </div>
      </div>
      <div class="side right">
        <div>15</div>
      </div>
      <div class="side">
        <div>2 star</div>
      </div>
      <div class="middle">
        <div class="bar-container">
          <div class="bar-2"></div>
        </div>
      </div>
      <div class="side right">
        <div>6</div>
      </div>
      <div class="side">
        <div>1 star</div>
      </div>
      <div class="middle">
        <div class="bar-container">
          <div class="bar-1"></div>
        </div>
      </div>
      <div class="side right">
        <div>20</div>
      </div>
    </div>
        </div>
<div style="width:100%; height:700px;border-bottom: 2px solid grey; border-top: 2px solid grey">
     <div style="width: 70%; float:left; height:500px;">
                  <img src="https://www.w3schools.com/w3images/avatar5.png" alt="Avatar" class="avatar">
                   <h3>Thinking to buy another one!</h3>

        <span class="fa fa-star checked"></span>
        <span class="fa fa-star checked"></span>
        <span class="fa fa-star checked"></span>
        <span class="fa fa-star checked"></span>
        <span class="fa fa-star checked"></span>
         <p>Reviewed in the United Kingdom on March 3, 2017</p>
         <p>This is my third Invicta Pro Diver. They are just fantastic value for money. This one arrived yesterday and the first thing I did was set the time, popped on an identical strap from another Invicta and went in the shower with it to test the waterproofing.... No problems.
            It is obviously not the same build quality as those very expensive watches. But that is like comparing a Citroën to a Ferrari. This watch was well under £100! An absolute bargain.</p>
          <a href="#" class="block mb-5 text-sm font-medium text-blue-600 hover:underline dark:text-blue-500">Read more</a><br />
         <a href="#" class="text-gray-900 bg-white border border-gray-300 focus:outline-none hover:bg-gray-100 focus:ring-4 focus:ring-gray-200 font-medium rounded-lg text-xs px-2 py-1.5 dark:bg-gray-800 dark:text-white dark:border-gray-600 dark:hover:bg-gray-700 dark:hover:border-gray-600 dark:focus:ring-gray-700">Helpful</a>
                <a href="#" class="pl-4 text-sm font-medium text-blue-600 hover:underline dark:text-blue-500">Report abuse</a>
    </div>
    <div class="galeria" style="width: 260px; float:right; height:300px;">
      <input type="radio" name="navegacion" id="_1" checked>
      <input type="radio" name="navegacion" id="_2">
      <input type="radio" name="navegacion" id="_3">
      <input type="radio" name="navegacion" id="_4"> 
      <img src="https://images.milanuncios.com/api/v1/ma-ad-media-pro/images/555a8352-8d8e-43dc-b7a6-a69906f91ff5?rule=hw396_70" width="260" height="300" alt="Galeria CSS 1" />
      <img src="https://cdn.wallapop.com/images/10420/et/h7/__/c10420p896038706/i3255661981.jpg?pictureSize=W640" width="260" height="300" alt="Galeria CSS 2"  />
      <img src="https://images.cashconverters.es/productslive/juego-ps5/nba-2k23_CC005_E927156-0_1.jpg" width="260" height="300" alt="Galeria CSS 3" />
      <img src="https://image.api.playstation.com/vulcan/ap/rnd/202207/0817/VbYdwoLSaCU6J8raRVdLrS2m.jpg" width="260" height="300" alt="Galeria CSS 4" />
    </div>
 </div>
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
  width: 260px;
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

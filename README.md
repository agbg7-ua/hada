## PARTICIPANTES
- Andrea Gómez Bobes
- Carlos Pérez Pascual
- Jorge Sánchez Pastor
- Salma Benmoussa
- Carolina Fernández

## DESCRIPCIÓN
Nuestra propuesta es una web de venta de videojuegos. En ella se encontrará una buena gama de videojuegos de diferentes géneros y plataformas.
A continuación, se detallaran las características más importantes.

## PARTE PÚBLICA 
Esta es la parte de la web a la que cualquier persona tiene acceso, en ella se verán los productos, que, en esta propuesta, son los videojuegos y también sus categorías. Adicionalmente se podrán ver las ofertas que ofrece nuestra web, así como los desarrolladores de los videojuegos.

## ENTIDADES PÚBLICAS
- Juegos (productos): Es la base de nuestra web, lo que se le ofrece al comprador, vendemos videojuegos. Esta entidad tendrá tanto el nombre del juego, como una breve descripción, el precio, el año de lanzamiento,  la clasificación según la edad del mismo. También ofreceremos las valoraciones de cada uno de los productos (ver Comentarios), en caso de haber.

- Categoría de los productos: Esta entidad hace referencia principalmente a los distintos tipos de genéros de videojuegos que se encuentran disponibles en la web. Esta constará con el nombre del género y una breve descripción de este.

- Ofertas: Esta entidad es aquella que especifíca las promociones que proporciona nuestra web. Nuestra web contará con únicamente tres ofertas, las cuales serán creadas por un administrador, el cuál aplicará el porcentaje de descuento que le sea adecuado.

- Desarrollador: Hace referencia a los creadores de los videojuegos, tanto empresas como creadores individuales. Estará formada por el nombre del desarrollador, una breve descripción de la empresa o la persona individual, el país de origen, el año de fundación y su sitio web, además de una imagen.

## PARTE PRIVADA
Esta es la parte que verá únicamente el usuario que se registre, en ella estará su información personal y todas las interacciones que haya tenido con la página web.

## ENTIDADES 
- Usuario: Es la base de la parte privada de la web, el usuario se registra y así guarda su información personal. Esta entidad consta de el nombre de usuario, el nombre real de la persona y apellidos, su edad, su correo electrónico, su contraseña y la información personal que sea necesaria como su dirección o su teléfono.
- Pedido: Hace referencia al historial de una compra realizada, se muestra todo lo que se ha comprado y las características. Esta entidad está formada por el número de pedido, la fecha de este, el cliente que lo ha realizado y el importe.
- Línea pedido: Es cada línea del pedido, es decir cada producto que forma parte del pedido. Esta entidad contiene el número de línea que es, el número de pedido al que pertenece, el producto que es, la cantidad de productos y el precio total.
- Carrito: El carrito es una especie de historial de productos que se añaden para comprar justo antes de procesar el pago. Esta entidad está compuesta por un identificador de carrito, el usuario al que pertenece y el total del carrito.
- Línea carrito: Es cada línea del carrito, cada producto que figura en él. Esta entidad contiene el número de línea que es, el número de carrito al que pertenece, el producto que es, la cantidad de productos y el precio total.
- Comentarios: Esta entidad es el sistema de comentarios y respuestas a estos mismos que el usuario puede poner respecto a un producto concreto. Estará formada por un identificador de comentario, el usuario que puso ese comentario, el producto comentado, la fecha y la hora de este comentario, el propio comentario en sí, una valoriación numérica del producto.

## POSIBLES MEJORAS
Vamos a detallar algunas de las posibles mejoras que podríamos añadir si todo funciona sin muchos inconvenientes y si entra dentro del plazo de entrega.
Lo primero que tenemos pensado como añadir sería una oferta mensual en la página, que cada mes un juego concreto tenga un descuento y sea ofertado en la página.
Lo segundo que pensamos para añadir sería un sistema de mensajes privados entre usuarios para que puedan relacionarse entre ellos de manera privada.
Por último, y la posible mejora principal sería hacer que los usuarios también puedan vender sus juegos que ya no usen y que estén en buen estado, para esto deberíamos añadir bastantes cosas como por ejemplo un sistema para autentificar que los juegos están en buen estado y que no es una estafa.

## BASE DE DATOS
El script y el pdf de la base de datos se encuentra en la carpeta llamada "Base de Datos".

## ACLARACIONES ENTREGA 3
En esta tercera entrega, se podrán oberservar muchas de las funciones que un usuario cualquiera no podría reaalizar: como modificar un pedido, producto o desarroladora. Esto se debe a que como un extra, tendremos que crear un menú de administrador que será por la existencia de usuarios admin. Pero de esta forma, podemos enseñar todas las funcionalidades básicas que tendrá nuestra página web.
Además, para poder ver en su totalidad la página web, hay un script en la carpeta Base de Datos, la cual se podrá utilizar para añadir la base de datos directamente al programa. 
Por último, en la carpeta EntregaProyecto se encuentra esta entrega en el archivo entregaInterfaz.zip.

## ENTREGA FINAL
Todo lo detallado en la parte de "Entidades", ha sido implementado. Además, hemos añadido dos mejoras, las cuales se tratan de dos gráficas: Top 10 Producto más vendidos, y TOP 10 Usuarios que más han comprado en nuestra web. Debido a las especificaciones de la práctica, esta última gráfica no es del todo realista ya que solo hemos añadido dos usuarios (como indica la práctica). Además de estas mejoras, cabe destacar que hemos creado una propiedad en los Usuarios que es: administración. Si un usuario es admin, podrá acceder a a una página de Administrador donde se le permite administrar algunas entidades, y podrá realizar funciones básicas CRUD (donde se haya vbisto posible), por ejemplo, no tiene sentido que un administrador sea capaz de eliminar un carrito o eliminar un pedido cuando este ya ha sido realizado.

## INSTRUCCIONES DE USO
Para empezar, debe eliminar la carpeta que se llama App_data y agregar un nuevo elemento en tiendaWeb, que será una Base de Datos de SQL Server, al que tendrá que llamar: Database.mdf.  
Una vez agregada la Base de Datos, tendrá que hacer una nueva consulta y copiar y pegar el contenido del archivo llamado: "Script_Database.sql" que se encuentra dentro de la carpeta: "Base de Datos". A continuación, compruebe que la página llamada "Home.aspx" esté establecida como página de inicio. Ahora ya podrá lanzar la página, en caso de que de error, sitúese en el archivo "Home.aspx", y vaya a la parte de "Diseño". Una vez se haya cargado, vuelva a lanzar la página. Técnicamente, eso será suficiente.  
Para introducir datos en la página, realice una nueva consulta en la base de datos y coppie y pegue el contenido del archivo llamado "Rellenar base de datos.sql", que se encuentra en el archivo "Base de Datos".  
En caso de que quiera explorar la web como un usuario no administrador, regístrese con el username: usuario; y contraseña: usuario.  
En caso de que quiera disfrutar de las libertades de un administrador, regístrese con el username: profesor; y la contraseña: profesor.

## TABLA DE TRABAJOS REALIZADOS POR ALUMNO  

| Andrea Gómez Bobes | ENUsuario.cs, CADUsuario.cs, ENComentario.cs, CADComentario.cs, Comentario.aspx, EditUsuario.aspx, NuevoComentario.aspx, Registro.aspx, Usuario.aspx |
| Carlos Pérez Pascual | ENPedido.cs, CADPedido.cs, ENLineaPedido.cs, CADLineaPedido.cs, LineaPedido.aspx, Pedido.aspx, SobreNosotros.aspx |
| Jorge Sánchez Pastor | ENDesarrollador.cs, CADDesarrollador.cs, ENOferta.cs, CADOferta.cs, Desarrollador.aspx, ListaDesarrolladores.aspx, Oferta.aspx, DesarrolladorAdmin.aspx, EditarDesarrolladorAdmin.aspx, InsertarDesarrolladorAdmin.aspx, OfertaAdmin.aspx |

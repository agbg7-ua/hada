
## DESCRIPCIÓN
Nuestra propuesta es una web de venta de videojuegos. En ella se encontrará una buena gama de videojuegos de diferentes géneros y plataformas.
A continuación, se detallaran las características más importantes.

## PARTE PÚBLICA 
Esta es la parte de la web a la que cualquier persona tiene acceso, en ella se verán los productos, que, en esta propuesta, son los videojuegos y también sus categorías. Adicionalmente se podrán ver las ofertas que ofrece nuestra web, así como los desarrolladores de los videojuegos.

## ENTIDADES PÚBLICAS
- Juegos (productos): Es la base de nuestra web, lo que se le ofrece al comprador, vendemos videojuegos. Esta entidad tendrá tanto el nombre del juego, como una breve descripción, el precio, el año de lanzamiento, plataforma/s en el que se juega, los idiomas, los requisitos del sistema y la clasificación según la edad del mismo. También ofrecermos las valoraciones de cada uno de los productos, en caso de haber.

- Categoría de los productos: Esta entidad hace referencia principalmente a los distintos tipos de genéros de videojuegos que se encuentran disponibles en la web. Esta constará con el nombre del género, una breve descripción de este, el tipo de audiencia a la que va dirigido, mecánicas de ese tipo de juegos, las habilidades más valoradas en ese tipo de género y las dificultades que pueden presentar estos.

- Ofertas: Esta entidad es aquella que especifíca las promociones que proporciona nuestra web. Esta estará formada por el nombre de la oferta, una descripción de la misma, el tipo de oferta que es (2x1, porcentaje de descuento, paquetes de juegos que salen más baratos juentos, etc.), el porcentaje de descuento que se aplica o la cantidad a descontar, código de descuento si es necesario aplicar uno, fecha en la que empieza la oferta y en la que acaba y las restricciones que esta presenta ( por ejemplo un importe mínimo de compra para poder ser aplicado el descuento).

- Desarrollador: Hace referencia a los creadores de los videojuegos, tanto empresas como creadores individuales. Estará formada por el nombre del desarrollador, una breve descripción de la empresa o la persona individual, el país de origen, el año de fundación, tanto su sitio web como sus redes sociales, algunos de sus juegos más populares, el tipo de videojuegos que suelen crear, premios que hayan obtenido con algunos de sus juegos, las tecnologías utilizadas para el desarrollo de los mismos y las plataformas en las que sus videojuegos se pueden jugar.

## PARTE PRIVADA
Esta es la parte que verá únicamente el usuario que se registre, en ella estará su información personal y todas las interacciones que haya tenido con la página web.

## ENTIDADES 
- Usuario: Es la base de la parte privada de la web, el usuario se registra y así guarda su información personal. Esta entidad consta de el nombre de usuario, el nombre real de la persona y apellidos, su edad, su correo electrónico, su contraseña, géneros de juego favoritos, historial de juegos, de pagos y de compras, amigos o personas a las que haya agregado,direcciones de envío añadidas, preferencia de idiomas y comentarios que este haya publicado.
- Pedido: Hace referencia al historial de una compra realizada, se muestra todo lo que se ha comprado y las características. Esta entidad está formada por el número de pedido, la fecha de este, el cliente que lo ha realizado, la dirección de envío, el método de envío, el estado del pedido, el importe, los artículos pedidos, el método de pago y observaciones si las hay.
- Línea pedido: Es cada línea del pedido, es decir cada producto que forma parte del pedido. Esta entidad contiene el número de línea que es, el número de pedido al que pertenece, el producto que es, la cantidad de productos,algunas obsevaciones si son necesarias, el precio por unidad y el precio total.
- Carrito: El carrito es una especie de historial de productos que se añaden para comprar justo antes de procesar el pago. Esta entidad está compuesta por un identificador de carrito, el usuario al que pertenece, los productos que lo conforman, el total del carrito, descuentos y cupones que se estén utilizando, dirección de envío, método de pago que se vaya a usar y el estado del carrito ( como por ejemplo si se ha comprado ya, si está en activo ya que se siguen añadiendo cosas o si está abandonado).
- Línea carrito: Es cada línea del carrito, cada producto que figura en él. Esta entidad contiene el número de línea que es, el número de carrito al que pertenece, el producto que es, la cantidad de productos,algunas obsevaciones si son necesarias, el precio por unidad y el precio total.
- Comentarios: Esta entidad es el sistema de comentarios y respuestas a estos mismos que el usuario puede poner respecto a un producto concreto. Adicionalmente los usuarios pueden contestarse unos a otros en estos comentarios. Estará formada por un identificador de comentario, el usuario que puso ese comentario, el producto comentado, la fecha y la hora de este comentario, el propio comentario en sí, una valoriación numérica del producto, el estado del comentario (publicado, eliminado, en edición,etc.) , las respuestas a este comentario y observaciones si son necesarias.

## POSIBLES MEJORAS
Vamos a detallar algunas de las posibles mejoras que podríamos añadir si todo funciona sin muchos inconvenientes y si entra dentro del plazo de entrega.
Lo primero que tenemos pensado como añadir sería una oferta mensual en la página, que cada mes un juego concreto tenga un descuento y sea ofertado en la página.
Lo segundo que pensamos para añadir sería un sistema de mensajes privados entre usuarios para que puedan relacionarse entre ellos de manera privada.
Por último, y la posible mejora principal sería hacer que los usuarios también puedan vender sus juegos que ya no usen y que estén en buen estado, para esto deberíamos añadir bastantes cosas como por ejemplo un sistema para autentificar que los juegos están en buen estado y que no es una estafa.

## PDF BBDD
El pdf se encuentro en la rama máster, carpeta Base de Datos y el pdf se llama Database.

-- Rellenar Usuario
insert into Usuario values('profesor', 'Héctor', 'Sempere Pérez', 'profesor@gmail.com', '0Ix96dAlnP5LMz/OMHij2FA/jFc=', 23, 'Sant Vicent del Raspeig', 'San Vicente', 'San Vicente', '03080', '965903400', 1)
insert into Usuario values('usuario', 'usuario', 'usuario usuario', 'usuario@gmail.com', 'tjs01Yc7rZPJLskMdK4KQjLmRzs=', 56, 'calle usuario', 'pueblo usuario', 'provincia usuario', '12345', '123456789', 0)

-- Rellenar CategoriaProducto
insert into CategoriaProducto values('Lucha', 'Género de videojuego que se basa en manejar un personaje que pelea, ya sea dando golpes, usando poderes mágicos o aplicando llaves.', '~/Imagenes/Generos/Lucha.jpg', 0)
insert into CategoriaProducto values('Arcade', 'Juegos relativamente fáciles de jugar o que no responden fielmente a la gravedad y otras fuerzas.', '~/Imagenes/Generos/Arcade.png', 0)
insert into CategoriaProducto values('Estrategia', 'Género de videojuego donde se ponen a prueba diferentes habilidades de planificación, pensamiento crítico, resolución de problemas y gestión de recursos; con el fin de lograr un objetivo o conseguir la victoria para pasar a otro nivel.', '~/Imagenes/Generos/Estrategia.jpg', 0)
insert into CategoriaProducto values('Guerra', 'Videojuegos que recrean un enfrentamiento armado de cualquier escala (de escaramuza, táctico, operacional, estratégico o global).', '~/Imagenes/Generos/Guerra.jpg', 0)
insert into CategoriaProducto values('Simulación', 'Los juegos de simulación son una aproximación a la realidad o, mejor dicho, una representación simplificada.', '~/Imagenes/Generos/Simulación.jpg', 0)
insert into CategoriaProducto values('Deporte', 'Videojuegos de consola o de computadora que simulan el campo de deportes tradicionales.', '~/Imagenes/Generos/Deporte.jpg', 0)
insert into CategoriaProducto values('Carreras', 'Videojuegos en el que se imitan competencias entre vehículos.', '~/Imagenes/Generos/Carreras.png', 0)
insert into CategoriaProducto values('Acción-Aventura', 'Género de videojuegos, caracterizados por la investigación, exploración, la solución de rompecabezas, la interacción con personajes del videojuego, y un enfoque en el relato en vez de desafíos basados en reflejos.', '~/Imagenes/Generos/Aventura.jpg', 0)
insert into CategoriaProducto values('Terror y Supervivencia', 'Subgénero de los videojuegos de terror y de acción y aventura que se centra en el personaje y su travesia por la sobrevivencia, mientras al mismo tiempo se intenta asustar a los jugadores con diferentes elementos del terror.', '~/Imagenes/Generos/Terror.jpg', 0)
insert into CategoriaProducto values('Musical', 'Juegos que inducen a la interacción del jugador con la música y cuyo objetivo es seguir los patrones de una canción en el videojuego', '~/Imagenes/Generos/Musical.png', 0)
insert into CategoriaProducto values('Agilidad Mental', 'Videojuegos enfocados en reforzar la concentración y la focalización de detalles.', '~/Imagenes/Generos/Agilidad.jpg', 0)
insert into CategoriaProducto values('Educativo', 'Videojuego interactivo por medio del que se puede aprender uno o varios temas.', '~/Imagenes/Generos/Educativo.jpg', 0)

-- Rellenar Desarrollador
insert into Desarrollador values('Deconstructeam', 'Deconstructeam es una empresa española desarrolladora de videojuegos pertenecientes al género independiente, posee uno de los únicos estudios de desarrollo independiente ubicados en la Comunidad Valenciana.', 'España', '2012-12-03', 'www.deconstructeam.com', '~/Imagenes/decostructeam.jpg', 0)
insert into Desarrollador values('Blendo Games', 'Blendo Games es una empresa estadounidense independiente de desarrollo de videojuegos con sede en Culver City, California. Fue fundado por Brendon Chung en 2010 y es principalmente un esfuerzo de una sola persona.', 'Estados Unidos', '2010-01-01', 'blendogames.com', '~/Imagenes/blendo.jpg', 0)
insert into Desarrollador values('Electronic Arts', 'Electronic Arts Inc. es una empresa estadounidense desarrolladora y distribuidora de videojuegos, fundada por Trip Hawkins el 27 de mayo de 1982 en San Mateo, California. Sus oficinas centrales están en Redwood City, California. ', 'Estados Unidos', '1972-12-03', 'ea.com', '~/Imagenes/download.jpg', 0)
insert into Desarrollador values('Bungie Studios', 'Bungie Studios, comúnmente conocido como Bungie, Inc., o simplemente Bungie, es una empresa diseñadora de videojuegos fundada en 1991 bajo el nombre «Bungie Software Products Corporation» antes de su emancipación de Microsoft, por dos estudiantes de la Universidad de Chicago: Alex Seropian y Jason Jones', 'Estados Unidos', '2016-01-01', 'bungie.net', '~/Imagenes/Bungie-Studios.png', 0)
insert into Desarrollador values('nintendo', 'Nintendo Company, Ltd. es una empresa de entretenimiento dedicada a la investigación, desarrollo y distribución de software y hardware de videojuegos, y juegos de cartas, con sede en Kioto, Japón.', 'Japon', '1889-09-26', 'nintendo.es', '~/Imagenes/nintendo.png', 0)
insert into Desarrollador values('Platinum Games', 'PlatinumGames es una empresa desarrolladora de videojuegos japonesa. Fundada en febrero de 2006? por Atsushi Inaba y Hideki Kamiya, ? bajo el nombre de SEEDS Inc., tras la disolución de Clover Studio.? La empresa mantiene gran parte de la plantilla de Clover Studios, como Shinji Mikami, creador de Resident Evil.', 'Japon', '2006-01-02', 'platinumgames.com', '~/Imagenes/platinum.jpg', 0)
insert into Desarrollador values('Ubisoft', 'Ubisoft Entertainment S. A. es una empresa desarrolladora y distribuidora de videojuegos francesa, fundada el 28 de marzo de 1986 en Carentoir, en Bretaña, Francia. Yves Guillemot, uno de los fundadores, es el actual director ejecutivo y presidente de la compañía.?', 'Francia', '1986-02-03', 'ubisoft.com', '~/Imagenes/images.jpg', 0)

-- Rellenar Producto
insert into Producto values(8, 1, 'Dead Island 2', 56.95, 'Dead Island 2 es una experiencia de acción de mundo abierto realizada por Dambuster Studios, el estudio británico conocido por Homefront: The Revolution.', '2023-04-21', 5, '~/Imagenes/Videojuegos/dead-island-2.jpg', 1, 0)
insert into Producto values(8, 2, 'Star Wars Jedi: Survivor', 62.95, 'Tras Jedi: Fallen Order llega Star Wars Jedi: Survivor, el siguiente capítulo en la historia de Cal Kestis desarrollado por Respawn Entertainment bajo edición de EA.', '2023-04-28', 3, '~/Imagenes/Videojuegos/jedi-survivor.jpg', 1, 0)
insert into Producto values(8, 3, 'Redfall', 69.95, 'Redfall es un shooter cooperativo de mundo abierto en primera persona desarrollado por Arkane Austin, el equipo responsable de Prey y Dishonored.', '2023-05-02', 5, '~/Imagenes/Videojuegos/redfall.jpg', 1, 0)
insert into Producto values(8, 4, 'Resident Evil 4: Remake', 62.95, 'Resident Evil 4: Remake trae de vuelta el survival-horror que conserva la esencia del videojuego original, a la vez que introduce mecánicas de juego actualizadas, una historia reimaginada y gráficos de última generación que lo convierten en la experiencia de supervivencia y terror definitiva en la cual se cruzan la vida y la muerte.', '2023-03-24', 5, '~/Imagenes/Videojuegos/resident-evil-4.jpg', 1, 0)
insert into Producto values(8, 5, 'Ravenlok', 22.39, 'Ravenlok se presenta como una fábula de acción, un cuento de hadas reimaginado que narra la historia un reino doblegado por una Reina corrupta y una joven que sigue su destino para cumplir una peligrosa profecía.', '2023-05-04', 2, '~/Imagenes/sinimagen.jpeg', 1, 0)
insert into Producto values(8, 6, 'Spider-Man', 39.95, 'En el espectacular Marvels Spider-Man te esperan saltos, combos de combates, carreras y acrobacias aprovechando el uso de técnicas de Parkour y muchas, muchas telarañas gestionadas por un extenso y variado sistema de combos y habilidades que ofrecen gran libertad de movimientos y posibilidades.', '2022-08-12', 4, '~/Imagenes/Videojuegos/spider-man.jpg', 1, 0)
insert into Producto values(8, 7, 'A Plague Tale: Innocence', 49.95, ' La historia de los hermanos Amicia y Hugo sobrecoge, con una mezcla de realismo y fantasía que se traduce en la pantalla a través de mecánicas pausadas de sigilo y puzles que os mantendrán atrapados durante las cerca de 10 horas que dura.', '2019-05-14', 5, '~/Imagenes/Videojuegos/tale-innocence.jpg', 1, 0)
insert into Producto values(8, 1, 'Daymare: 1998', 19.99, 'Daymare 1998 consigue emular de manera acertada todo lo que hace la fórmula Resident Evil.', '2019-09-17', 5, '~/Imagenes/Videojuegos/daymare.jpg', 1, 0)
insert into Producto values(8, 2, 'Marvels Guardianes de la Galaxia', 19.99, 'No es fácil cambiar el medio a una licencia y hacerlo con tanto éxito como lo ha hecho Eidos Montreal. Sí, hay algunas secciones algo anticuadas y fuera de lugar que se combinan con algunos problemas técnicos de sencilla solución en las próximas semanas, pero todas las luces de Guardianes de la Galaxia eclipsan cualquier sombra sobre el proyecto.', '2021-10-26', 3, '~/Imagenes/Videojuegos/guardianes.jpg', 1, 0)
insert into Producto values(8, 3, 'Far Cry 6', 44.95, 'Far Cry 6 es el juego más completo de toda la franquicia. Es casi inabarcable, con una cantidad de contenido que abruma. Y, sin embargo, la fórmula se nota anquilosada cuando insta a la reiteración de objetivos y visitas a campamentos enemigos.', '2021-10-07', 5, '~/Imagenes/Videojuegos/farcry6.png', 1, 0)
insert into Producto values(8, 4, 'Red Dead Redemption 2', 26.95, 'Red Dead Redemption 2 desembarca por fin en PC con todas las balas del cargador de su revólver preparadas para hacer fuego pero, además, con un apartado gráfico muy mejorado. Elementos como alguna misión extra y el ansiado modo foto ayudan a redondear su oferta jugable, pero lo realmente formidable es la posibilidad de obtener una experiencia visual mejor incluso que la de consola.', '2019-11-05', 5, '~/Imagenes/Videojuegos/redemption2.png', 1, 0)
insert into Producto values(8, 5, 'The Callisto Protocol', 19.99, 'The Callisto Protocol es un videojuego de horror y supervivencia para un jugador en el que la historia juega un papel clave firmado por los creadores de Dead Space, el clásico moderno de la extinta Visceral Games.', '2022-12-02', 5, '~/Imagenes/Videojuegos/callisto.jpg', 1, 0)
insert into Producto values(8, 6, 'La Tierra Media: Sombras de Guerra', 39.95, 'Sombras de Guerra ya no es la sorpresa que supuso el primer viaje por Mordor, pero no sólo atesora todas las virtudes de su predecesor sino que además las explota en nuevas direcciones.', '2017-10-10', 4, '~/Imagenes/sinimagen.jpeg', 1, 0)
insert into Producto values(8, 7, 'Star Wars Jedi: Fallen Order', 19.99, 'Star Wars Jedi: Fallen Order propone desarrollar las habilidades de la Fuerza de su protagonista, Cal Kestis, mejorar sus técnicas con la espada láser, explorar los antiguos misterios de una civilización perdida hace muchos años y desvelar nuevos conocimientos de la Fuerza.', '2019-11-15', 4, '~/Imagenes/Videojuegos/jedi.png', 1, 0)
insert into Producto values(8, 1, 'La Tierra-Media: Sombras de Mordor', 26.95, 'Repleto de cosas por hacer y tremendamente absorbente, este título rebosa diversión por todos lados, seas fan o no de la fantasía de Tolkien.', '2014-09-30', 5, '~/Imagenes/sinimagen.jpeg', 1, 0)
insert into Producto values(8, 2, 'Crayon Shin chan', 69.99, 'Shin-Chan: Me and the Professor on Summer Vacation es un videojuego de acción y aventura enmarcado dentro de la saga japonesa donde, cámara en mano, acompañamos a Shinnosuke en sus vacaciones de verano por los hermosos campos y montañas de Assou, un lugar que alberga una leyenda misteriosa y que está repleto de personajes interesantes de todo tipo a los que conocer, incluído un profesor malvado.', '2022-08-11', 1, '~/Imagenes/sinimagen.jpeg', 1, 0)
insert into Producto values(8, 3, 'A Plague Tale: Requiem', 54.95, 'A Plague Tale: Requiem trae de vuelta a Amicia y Hugo tras la primera y aclamada aventura de Asobo Studio y Focus Home Interactive, en una segunda parte de Innocence que duplica la duración de la campaña del original.', '2022-10-18', 5, '~/Imagenes/Videojuegos/plague.png', 1, 0)
insert into Producto values(8, 4, 'Grand Theft Auto V', 17.95, 'Grand Theft Auto V transporta al jugador a Los Santos, una extensa y soleada metrópolis en declive que lucha por mantenerse a flote en una era de incertidumbre económica y realities baratos que referencia de una forma paródica a la Los Ángeles de nuestro tiempo.', '2015-04-14', 5, '~/Imagenes/Videojuegos/gta.png', 1, 0)

-- Rellenar Comentario
insert into Comentario values(4, 'usuario', '2019-06-23', 'No me has gustado tanto como pensaba', 2)
insert into Comentario values(5, 'usuario', '2019-12-04', '¿Por qué me he pasado el juego en un día? Me ha encantado', 5)
insert into Comentario values(6, 'usuario', '2019-08-05', 'Sin comentarios...', 1)
insert into Comentario values(7, 'usuario', '2019-08-29', 'Uno de los juegos que podría tirar y no sentirme mal por ello.', 1)
insert into Comentario values(8, 'usuario', '2022-11-23', 'No está mal, pensaba que iba a ser más entretenido', 3)
insert into Comentario values(9, 'usuario', '2023-01-09', 'WOW', 4)
insert into Comentario values(10, 'usuario', '2023-03-13', 'Ya me lo he pasado, y me lo voy a volver a empezar!!', 4)

-- Rellenar Pedido
insert into Pedido values('usuario', '2023-05-05' , 258.65)
insert into Pedido values('usuario', '2023-05-06' , 19.99)
insert into Pedido values('usuario', '2023-05-07' , 69.95)
insert into Pedido values('usuario', '2023-05-08' , 39.95)
insert into Pedido values('usuario', '2023-05-09' , 182.85)
insert into Pedido values('usuario', '2023-05-10' , 89.75)

-- Rellenar LineaPedido
insert into LineaPedido values(1, 3, 1, 69.95)
insert into LineaPedido values(1, 18, 3, 53.85)
insert into LineaPedido values(1, 10, 1, 44.95)
insert into LineaPedido values(1, 2, 1, 62.95)
insert into LineaPedido values(1, 15, 1, 26.95)
insert into LineaPedido values(2, 8, 1, 19.99)
insert into LineaPedido values(3, 3, 1, 69.95)
insert into LineaPedido values(4, 6, 1, 39.95)
insert into LineaPedido values(5, 1, 1, 56.95)
insert into LineaPedido values(5, 2, 1, 62.95)
insert into LineaPedido values(5, 4, 1, 62.95)
insert into LineaPedido values(6, 18, 5, 89.75)

SET IDENTITY_INSERT [dbo].[Oferta] ON
INSERT INTO [dbo].[Oferta] ([id], [oferta], [id_producto]) VALUES (1, CAST(48.47 AS Decimal(7, 2)), 4)
INSERT INTO [dbo].[Oferta] ([id], [oferta], [id_producto]) VALUES (2, CAST(27.97 AS Decimal(7, 2)), 6)
INSERT INTO [dbo].[Oferta] ([id], [oferta], [id_producto]) VALUES (3, CAST(21.98 AS Decimal(7, 2)), 17)
SET IDENTITY_INSERT [dbo].[Oferta] OFF

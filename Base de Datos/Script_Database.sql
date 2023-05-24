-- USUARIO

CREATE TABLE [dbo].[Usuario] (
    [username]     	VARCHAR (30) NOT NULL,
    [nombre]  		VARCHAR (30) NOT NULL,
    [apellidos]    	VARCHAR (60) NULL,
    [email] 		VARCHAR (45) NOT NULL,
    [contraseña]       	VARCHAR (30) NOT NULL,
    [edad]  		INT          NULL,
    [calle]      	VARCHAR (45) NOT NULL,
    [pueblo]      	VARCHAR (45) NOT NULL,
    [provincia]     	VARCHAR (30) NOT NULL,
    [codigo_postal]    	VARCHAR (6)  NOT NULL,
    [telefono]    	VARCHAR (18) NULL,
    [admin]		BIT	     DEFAULT ((0)) NOT NULL, 
    PRIMARY KEY CLUSTERED ([username] ASC),
    UNIQUE NONCLUSTERED ([email] ASC)
);

-- --------------------------------------------------------------------------------------------
-- CATEGORIA PRODUCTO

CREATE TABLE [dbo].[CategoriaProducto] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [nombre]      VARCHAR (45)  NOT NULL,
    [descripcion] TEXT          NOT NULL,
    [imagen]      VARCHAR (MAX) NULL,
	[borrado]          BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([nombre] ASC)
);

-- --------------------------------------------------------------------------------------------
-- DESARROLLADOR

CREATE TABLE [dbo].[Desarrollador] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [nombre]         VARCHAR (30)  NOT NULL,
    [descripcion]    TEXT          NOT NULL,
    [origen]         VARCHAR (25)  NOT NULL,
    [fecha_creacion] DATE          NOT NULL,
    [web]            VARCHAR (50)  NULL,
    [imagen]         VARCHAR (MAX) NULL,
	[borrado]          BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([nombre] ASC)
);

-- --------------------------------------------------------------------------------------------
-- PRODUCTO

CREATE TABLE [dbo].[Producto] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [id_categoria]     INT            NOT NULL,
    [id_desarrollador] INT            NOT NULL,
    [nombre]           VARCHAR (45)   NOT NULL,
    [pvp]              DECIMAL (7, 2) NULL,
    [descripcion]      TEXT           NOT NULL,
    [fecha_salida]     DATE           NOT NULL,
    [clasificacion]    INT            NULL,
    [imagen]           VARCHAR (MAX)  NULL,
    [mostrar]          BIT            DEFAULT ((0)) NOT NULL,
    [borrado]          BIT            DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([nombre] ASC),
    CONSTRAINT [fk_Producto_CategoriaProducto] FOREIGN KEY ([id_categoria]) REFERENCES [dbo].[CategoriaProducto] ([id]) ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT [fk_Producto_Desarrollador] FOREIGN KEY ([id_desarrollador]) REFERENCES [dbo].[Desarrollador] ([id]) ON DELETE CASCADE ON UPDATE CASCADE
);
-- --------------------------------------------------------------------------------------------
-- COMENTARIO

CREATE TABLE [dbo].[Comentario] (
    [id_producto] INT          NOT NULL,
    [id]          INT          IDENTITY (1, 1) NOT NULL,
    [id_usuario]  VARCHAR (30) NOT NULL,
    [fecha]       DATE         NOT NULL,
    [comentario]  TEXT         NOT NULL,
    [valoracion]  INT          NULL,
    PRIMARY KEY CLUSTERED ([id_producto] ASC, [id] ASC),
    CONSTRAINT [fk_Comentario_Producto] FOREIGN KEY ([id_producto]) REFERENCES [dbo].[Producto] ([id]) ON DELETE CASCADE,
    CONSTRAINT [fk_Comentario_Usuario] FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[Usuario] ([username]) ON DELETE CASCADE
);


-- --------------------------------------------------------------------------------------------
-- OFERTA

CREATE TABLE [dbo].[Oferta] (
    [id] 		INT  		IDENTITY (1, 1) NOT NULL,
    [oferta]      	DECIMAL (7,2)  	NULL,
    [id_producto]      	INT  	NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [fk_Oferta_Producto] FOREIGN KEY ([id_producto]) REFERENCES [dbo].[Producto] ([id])
);

-- --------------------------------------------------------------------------------------------
-- PEDIDO 

CREATE TABLE [dbo].[Pedido] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [id_usuario]    VARCHAR (30)   NOT NULL,
    [fecha]         DATE           NOT NULL,
    [importe_total] DECIMAL (7, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [fk_Pedido_Usuario] FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[Usuario] ([username]) ON DELETE CASCADE
);

----------------------------------------------------------------------------------------------
-- LINEA PEDIDO

CREATE TABLE [dbo].[LineaPedido] (
    [id_pedido]   INT            NOT NULL,
    [id_linea]    INT            IDENTITY (1, 1) NOT NULL,
    [id_producto] INT            NOT NULL,
    [cantidad]    INT            NOT NULL,
    [importe]     DECIMAL (7, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([id_pedido] ASC, [id_linea] ASC),
    CONSTRAINT [fk_LineaPedido_Pedido] FOREIGN KEY ([id_pedido]) REFERENCES [dbo].[Pedido] ([id]) ON DELETE CASCADE,
    CONSTRAINT [fk_LineaPedido_Producto] FOREIGN KEY ([id_producto]) REFERENCES [dbo].[Producto] ([id])
);

-- --------------------------------------------------------------------------------------------
-- CARRITO

CREATE TABLE [dbo].[Carrito] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [id_usuario]    VARCHAR (30)   NOT NULL,
    [importe_total] DECIMAL (7, 2) DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [fk_Carrito_Usuario] FOREIGN KEY ([id_usuario]) REFERENCES [dbo].[Usuario] ([username]) ON DELETE CASCADE
);


-- --------------------------------------------------------------------------------------------
-- LINEA CARRITO

CREATE TABLE [dbo].[LineaCarrito] (
    [id_carrito]  INT            NOT NULL,
    [id_linea]    INT            IDENTITY (1, 1) NOT NULL,
    [id_producto] INT            NOT NULL,
    [cantidad]    INT            DEFAULT ((1)) NOT NULL,
    [importe]     DECIMAL (7, 2) NOT NULL,
    [fecha]       DATE           NOT NULL,
    PRIMARY KEY CLUSTERED ([id_carrito] ASC, [id_linea] ASC),
    CONSTRAINT [fk_LineaCarrito_Producto] FOREIGN KEY ([id_producto]) REFERENCES [dbo].[Producto] ([id]),
    CONSTRAINT [fk_LineaCarrito_Carrito] FOREIGN KEY ([id_carrito]) REFERENCES [dbo].[Carrito] ([id]) ON DELETE CASCADE
);

-- --------------------------------------------------------------------------------------------
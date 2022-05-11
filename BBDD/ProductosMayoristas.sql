USE PopZone;
CREATE TABLE ProductosMayoristas(
    ID INTEGER IDENTITY(1,1),
    Nombre VARCHAR(100),
    Precio DECIMAL(6,2),
    Descripcion VARCHAR(100),
    Imagen VARCHAR(100),
    CONSTRAINT PK_ProductosMayoristas PRIMARY KEY(ID),
);
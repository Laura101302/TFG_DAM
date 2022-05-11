USE PopZone;
CREATE TABLE ProductosParticulares(
    ID INTEGER IDENTITY(1,1),
    Nombre VARCHAR(100),
    Precio DECIMAL(6,2),
    Descripcion VARCHAR(100),
    Imagen VARCHAR(100),
    ID_Vendedor INTEGER,
    CONSTRAINT PK_ProductosParticulares PRIMARY KEY(ID),
    CONSTRAINT FK_ProductosParticulares FOREIGN KEY(ID_Vendedor) REFERENCES VendedoresParticulares(ID),
);
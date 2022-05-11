USE PopZone;
CREATE TABLE VendedoresParticulares(
    ID INTEGER IDENTITY(1,1),
    DNI VARCHAR(9) UNIQUE,
    NombreCompleto VARCHAR(100),
    Informacion VARCHAR(200),
    CONSTRAINT PK_VendedoresParticulares PRIMARY KEY(ID),
);
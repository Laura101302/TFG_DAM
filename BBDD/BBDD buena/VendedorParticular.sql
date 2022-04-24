USE PopZone;
CREATE TABLE VendedorParticular(
    DNI VARCHAR(9),
    NombreCompleto VARCHAR(100),
    Informacion VARCHAR(200),
    CONSTRAINT PK_VendedorParticular PRIMARY KEY(DNI),
);
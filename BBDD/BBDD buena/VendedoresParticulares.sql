USE PopZone;
CREATE TABLE VendedoresParticulares(
    DNI VARCHAR(9),
    NombreCompleto VARCHAR(100),
    Informacion VARCHAR(200),
    CONSTRAINT PK_VendedoresParticulares PRIMARY KEY(DNI),
);
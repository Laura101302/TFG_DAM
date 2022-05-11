USE PopZone;
CREATE TABLE Usuarios(
    ID INTEGER IDENTITY(1,1),
    NombreCompleto VARCHAR(100),
    CorreoElectronico VARCHAR(50) UNIQUE,
    Contrasena VARCHAR(100),
    CONSTRAINT PK_Usuarios PRIMARY KEY(ID),
);
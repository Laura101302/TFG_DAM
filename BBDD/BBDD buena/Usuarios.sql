USE PopZone;
CREATE TABLE Usuarios(
    CorreoElectronico VARCHAR(50),
    NombreCompleto VARCHAR(100),
    Contrasena VARCHAR(100),
    CONSTRAINT PK_Usuarios PRIMARY KEY(CorreoElectronico),
);
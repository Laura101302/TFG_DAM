USE PopZone;
CREATE TABLE Opiniones(
    CorreoElectronico VARCHAR(50),
    Nombre VARCHAR(100),
    Apellidos VARCHAR(100),
    Telefono VARCHAR(12),
    Comentario VARCHAR(200),
    Calificacion VARCHAR(max),
    CONSTRAINT PK_Opiniones PRIMARY KEY(CorreoElectronico),
);
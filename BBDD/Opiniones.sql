USE PopZone;
CREATE TABLE Opiniones(
    ID INTEGER IDENTITY(1,1),
    Nombre VARCHAR(100),
    Apellidos VARCHAR(100),
    Telefono VARCHAR(12),
    CorreoElectronico VARCHAR(50),
    Comentario VARCHAR(200),
    Calificacion VARCHAR(max),
    CONSTRAINT PK_Opiniones PRIMARY KEY(ID),
);
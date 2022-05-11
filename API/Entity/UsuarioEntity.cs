using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Usuarios")]
public class UsuarioEntity
{

    [MaxLength(100)]
    public string NombreCompleto { get; set; }
    [MaxLength(100)]
    public string Contrasena { get; set; }
    [MaxLength(50)]
    public string CorreoElectronico { get; set; }
    public int ID { get; set; }
}

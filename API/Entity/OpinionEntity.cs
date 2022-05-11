using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Opiniones")]
public class OpinionEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(100)]
    public string Apellidos { get; set; }
    [MaxLength(12)]
    public string Telefono { get; set; }
    [MaxLength(200)]
    public string Comentario { get; set; }
    public string Calificacion { get; set; }
    [MaxLength(50)]
    public string CorreoElectronico { get; set; }
    public int ID { get; set; }

}

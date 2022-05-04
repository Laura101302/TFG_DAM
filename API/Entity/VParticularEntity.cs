using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("VendedoresParticulares")]
public class VParticularEntity
{

    [MaxLength(100)]
    public string NombreCompleto { get; set; }
    [MaxLength(200)]
    public string Informacion { get; set; }
    [MaxLength(9)]
    public string DNI { get; set; }

}

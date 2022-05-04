using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ProductosParticulares")]
public class PParticularEntity
{

    [MaxLength(100)]
    public string Nombre { get; set; }
    [MaxLength(6)]
    public decimal Precio { get; set; }
    [MaxLength(100)]
    public string Descripcion { get; set; }
    [MaxLength(100)]
    public string Imagen { get; set; }
    [MaxLength(9)]
    public string DNI_Vendedor { get; set; }
    public int ID { get; set; }

}
